class KeysSum:
    def __init__(self):
        self._alphabet = "abcdefghijklmnopqrstuvwxyz"

        self._alpha_len = len(self._alphabet)

    def encrypt(self, key, value):
        value_len = len(value)
        while len(key) < value_len:
            key += key
        result = ""
        for i in range(value_len):
            x = self._alphabet.find(value[i]) + 1
            k = self._alphabet.find(key[i]) + 1
            y = (x + k) % self._alpha_len
            result += self._alphabet[y-1]
        return result

    def decrypt(self, key, value):
        value_len = len(value)
        while len(key) < value_len:
            key += key
        result = ""
        for i in range(value_len):
            y = self._alphabet.find(value[i]) + 1
            k = self._alphabet.find(key[i]) + 1
            x = (y - k) % self._alpha_len
            result += self._alphabet[x-1]
        return result
