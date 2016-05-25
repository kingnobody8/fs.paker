using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Paker
{
    public class Directory
    {
        public const int FileStringByteSize = 56;

        //Data for actual file
        public byte[] file;
        public string filePath;
        public bool isInPak;

        //Data for pak storage
        public int byteLength;
        public int byteOffset;
        public string fileName;

        public int GetStructureByteSize()
        {
            return FileStringByteSize + 4 + 4;
        }

        public void ReadFileFromStream(FileStream stream)
        {
            BinaryReader reader = new BinaryReader(stream);
            this.file = reader.ReadBytes(this.byteLength);
            this.isInPak = true;
        }
        public void ReadFileFromPak(FileStream stream)
        {
            BinaryReader reader = new BinaryReader(stream);
            reader.BaseStream.Seek(this.byteOffset, SeekOrigin.Begin);
            this.file = reader.ReadBytes(this.byteLength);
            this.isInPak = true;
        }
        public void ReadHeaderFromStream(FileStream stream, int offset)
        {
            BinaryReader reader = new BinaryReader(stream);
            reader.BaseStream.Seek(offset, SeekOrigin.Begin);
            byte[] data = reader.ReadBytes(FileStringByteSize);
            this.fileName = Encoding.ASCII.GetString(data);
            //Get rid of extra '\0'
            for (int i = this.fileName.Length - 1; i >= 0; i--)
                if (this.fileName[i] == '\0')
                    this.fileName = this.fileName.Remove(i);

            this.byteLength = reader.ReadInt32();
            this.byteOffset = reader.ReadInt32();
        }
        public void WriteFileToStream(FileStream stream, int offset)
        {
            //WE need to pass in the offset, because we could be righting to pack or to file
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Seek(offset, SeekOrigin.Begin);
            writer.Write(this.file, 0, this.byteLength);
        }
        public void WriteHeaderToStream(FileStream stream, int offset)
        {
            //Get fileName into ASCII
            byte[] data = new byte[FileStringByteSize];
            byte[] temp = Encoding.ASCII.GetBytes(this.fileName);
            for (int i = 0; i < FileStringByteSize; i++)
            {
                if (i < temp.Length)
                    data[i] = temp[i];
                else
                    data[i] = 0;
            }
            //Seek to writing location
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Seek(offset, SeekOrigin.Begin);
            //Write data
            writer.Write(data);
            writer.Write(byteLength);
            writer.Write(byteOffset);
        }

        public Directory()
        {
            this.file = null;
            this.filePath = null;
            this.isInPak = false;

            this.byteLength = 0;
            this.byteOffset = 0;
        }
        public Directory(Directory that)
        {
            this.file = that.file;
            this.filePath = that.filePath;
            this.isInPak = that.isInPak;
            this.byteLength = that.byteLength;
            this.byteOffset = that.byteOffset;
            this.fileName = that.fileName;
        }

    };

    public class Header
    {
        public string signature;
        public int directoryLength;
        public int directoryOffset;

        public void WriteHeaderToStream(FileStream stream)
        {
            //Get signature into ASCII
            byte[] data = new byte[signature.Length];
            byte[] temp = Encoding.ASCII.GetBytes(this.signature);
            for (int i = 0; i < signature.Length; i++)
            {
                if (i < temp.Length)
                    data[i] = temp[i];
                else
                    data[i] = 0;
            }

            //Seek to writing location
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Seek(0, SeekOrigin.Begin);

            //Write data
            writer.Write(data);
            writer.Write(directoryLength);
            writer.Write(directoryOffset);

        }
        public bool ReadHeaderFromStream(FileStream stream, string sig)
        {
            BinaryReader reader = new BinaryReader(stream);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            byte[] data = new byte[sig.Length];
            data = reader.ReadBytes(sig.Length);
            string test = Encoding.ASCII.GetString(data);

            if (test != sig)
                return false;

            this.signature = sig;
            this.directoryLength = reader.ReadInt32();
            this.directoryOffset = reader.ReadInt32();

            return true;
        }
        public int GetByteSize()
        {
            return this.signature.Length + 4 + 4;
        }

        public Header()
        {
            signature = "PACK";
            directoryLength = 0;
            directoryOffset = GetByteSize();
        }
        public Header(Header that)
        {
            this.signature = that.signature;
            this.directoryLength = that.directoryLength;
            this.directoryOffset = that.directoryOffset;
        }
    };


    public class Pak
    {
        public Header mainHeader;
        public List<Directory> atlas;

      
        public int GetTotalBytes()
        {
            int bytes = 0;

            //Add size of MainHeader
            bytes += this.mainHeader.GetByteSize();

            //Add size of Files
            for (int i = 0; i < this.atlas.Count; i++)
                bytes += this.atlas[i].byteLength;

            //Add sizeof Atlas
            bytes += this.mainHeader.directoryLength;

            return bytes;
        }

        public Pak()
        {
            mainHeader = new Header();
            atlas = new List<Directory>();
        }
        public Pak(Pak that)
        {
            mainHeader = that.mainHeader;
            atlas = new List<Directory>();
            for (int i = 0; i < that.atlas.Count; i++)
                atlas.Add(that.atlas[i]);
        }

    };
}
