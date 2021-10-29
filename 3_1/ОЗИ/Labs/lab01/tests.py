from decryptor import KeysSum

coder = KeysSum()

_key = input("Input key: ")
_value = input("\nInput value: ")

encoded = coder.encrypt(_key, _value)
print(encoded)

decoded = coder.decrypt(_key, encoded)
print(decoded)
