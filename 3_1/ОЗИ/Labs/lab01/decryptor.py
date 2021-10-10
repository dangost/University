class KeysSum:
    def __init__(self):
        self._alphabet = "abcdefghijklmnopqrstuvwxyz" \
                        "ABCDEFGHIJKLMNOPQRSTUVWXYZ" \
                        "~`!@#$%^&*()-_=+" \
                        "0123456789" \
                        " "

        self._alpha_len = len(self._alphabet)

    def encrypt(self, key, value):
        value_len = len(value)
        while len(key) < value_len:
            key += key
        result = ""
        for i in range(value_len):
            x = self._alphabet.find(value[i])
            k = self._alphabet.find(key[i])
            y = (x + k) % self._alpha_len
            result += self._alphabet[y]
        return result

    def decrypt(self, key, value):
        value_len = len(value)
        while len(key) < value_len:
            key += key
        result = ""
        for i in range(value_len):
            y = self._alphabet.find(value[i])
            k = self._alphabet.find(key[i])
            x = (y - k) % self._alpha_len
            result += self._alphabet[x]
        return result
