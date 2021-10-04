import numpy as np

A1 = [
    [13.414, 25.414, 35.544],
    [9.543, 8.114, 7.655],
    [18.141, 12.898, 10.254],
]

B1 = [12.123, 13.414, 14.541]


def kramer(A, B) -> list:
    op = np.linalg.det(A)
    r = []
    for i in range(len(A)):
        VM = np.copy(A)
        VM[:, i] = B
        r.append(round((np.linalg.det(VM) / op), 3))
    return r


x1, x2, x3 = kramer(A1, B1)
print(f"x1 = {x1} \nx2 = {x2} \nx3 = {x3}")

print(np.matmul(A1, [x1, x2, x3]))
