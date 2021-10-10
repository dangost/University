from decryptor import KeysSum

coder = KeysSum()

_key = "HyjI12q"
_value = "London is The Capital of Great Britain!"

encoded = coder.encrypt(_key, _value)
print(encoded)

decoded = coder.decrypt(_key, encoded)
print(decoded)
