from decryptor import KeysSum

coder = KeysSum()


_key = "size"
_value = "llhbtazjgnglxa"

print(_key)
print(_value)

encr = coder.decrypt(_key, _value)

print(encr)
