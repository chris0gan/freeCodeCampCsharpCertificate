﻿
string ipv4Input = "107.31.1.5";
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

if(ValidateLength() && ValidateZeroes() && ValidateRange()) {
    Console.WriteLine($"id is a valid IPv4 address");
} else {
    Console.WriteLine($"ip is an invalid IPv4 address");
}

void ValidateLength() {
    string[] address = ipv4Input.Split(".");
    validLength = address.Length == 4;
}
void ValidateZeroes() {}
void ValidateRange() {}