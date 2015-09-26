void reverseChar(char* str) {
    const size_t len = strlen(str);

    for(size_t i=0; i<len/2; i++)
        swap(str[i], str[len-i-1]);
}

void reverseChar(char* str) {
    std::reverse(str, str + strlen(str));
}
