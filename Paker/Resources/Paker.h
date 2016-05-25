// - Pak File 
// - Creator -> Daniel Habig
//
// This implementation of the a pak file loader will load one and only one pak file at a time
// This is intended to be a quick and easy class to get pak loading going
// It is suggested that you make a Paker.cpp and place the functions in there
//--------------------------

#pragma once
#include <unordered_map>
#include <string>
#include <fstream>
using namespace std;



#define FILE_NAME_LENGTH 56


// signature	- used to determine if file is a valid pack file
// length		- the length in bytes of all the FileHeaders in the atlas
// offset		- the absolute position in bytes of the atlas
struct PakHeader
{
	char signature[SIGNATURE_LENGTH];
	int length;
	int offset;
};


// filename	- relative path of file
// length	- the size in bytes of the file
// offset	- the absolute position in bytes of the file
struct FileHeader
{
	char fileName[FILE_NAME_LENGTH];
	int byteLength;
	int byteOffset;
};


class Paker
{
private:
	static Paker* instance;
	Paker();

	std::unordered_map< string, FileHeader > atlas;
	fstream stream;

public:
	static Paker* GetInstance();
	static void DeleteInstance();

	void ClearPak(void);
	bool LoadPak(const char* _pak_file);
	bool IsInPak(const char* _file_name);
	bool GetAsset( const char* _asset_name, char** _buffer, unsigned int &_file_size );

};

//Paker Functions
Paker* Paker::instance = nullptr;

//Instance Functions
Paker::Paker()
{
}
Paker* Paker::GetInstance(void)
{
	if (!instance)
		instance = new Paker();
	return instance;
}
void Paker::DeleteInstance(void)
{
	if (instance)
	{
		instance->ClearPak();
		delete instance;
		instance = nullptr;
	}
}

//Main Functions
void Paker::ClearPak(void)
{
	//Close any open file streams
	if( this->stream.is_open() )
		this->stream.close();

	//Clears any internal memory
	this->atlas.clear();
}
bool Paker::LoadPak(const char* _pak_file)
{
	//Reset the list
	ClearPak();

	//Open stream
	this->stream.open(_pak_file, std::ios_base::in | std::ios_base::out | std::ios_base::binary);
	if( !this->stream.is_open() )
		return false;

	//Read Header
	PakHeader header;
	stream.read( reinterpret_cast<char*>(&header), sizeof(PakHeader) );

	//Test the signature
	string headSig;
	string testSig;
	for( int i = 0; i < SIGNATURE_LENGTH; i++ )
	{
		headSig.push_back( header.signature[i] );
		testSig.push_back( SIG[i] );
	}
	if( strcmp( testSig.c_str(), headSig.c_str() ) != 0 )
		return false;

	//If atlas exists
	if( header.length == 0 )
		return true;

	//Seek to the atlas
	stream.seekg( header.offset, ios_base::beg );

	//Get count of FileHeaders
	int AFH = header.length / sizeof( FileHeader );

	//Fill the atlas
	for( int i = 0; i < AFH; i++ )
	{
		//Seek to FileHeader location
		stream.seekg( header.offset + i * sizeof(FileHeader), ios_base::beg );

		//Create FileHeaderPair
		pair<string, FileHeader> FHP;

		//Copy data into FileHeaderPair
		stream.read( reinterpret_cast<char*>(&FHP.second), sizeof( FileHeader ) );
		FHP.first = FHP.second.fileName;

		//Place data into the map
		atlas.insert( FHP );
	}

	return true;	
}
bool Paker::IsInPak(const char* _file_name)
{
	//Get the iterator to the atlas map
	auto iter = this->atlas.find( _file_name );

	//Check if the iterator is valid
	if( iter == this->atlas.end() )
		return false;

	return true;
}
bool Paker::GetAsset( const char* _asset_name, char** _buffer, unsigned int& _file_size)
{
	//Test if file is in the PAK
	if( IsInPak( _asset_name ) == false )
		return false;

	//Go through atlas and find the mem location of the directory
	FileHeader header = atlas[ _asset_name ];

	//Set the _file_size
	_file_size = header.byteLength;

	//Allocate memory for the buffer
	*_buffer = new char[ _file_size ];

	//Seek to mem location
	stream.seekg( header.byteOffset, ios_base::beg );

	//Read memory into buffer
	stream.read( reinterpret_cast<char*>(*_buffer), _file_size );

	return true;
}