A = [
    [10.432, 4.431, 14.908, 41.123],
    [5.786, 15.451, 21.125, 51.545],
    [14.654, 13.782, 10.245, 18.987]
]

i = 0

while i < len(A):
    q = A[i][i]

    for j in range(i, len(A)):
        A[i][j] /= q

    for j in range(i + 1, len(A)):
        m = A[j][i]
        for k in range(0, len(A[i])):
            A[j][k] -= A[i][k] * m

    i += 1

x1 = A[2][3] / A[2][2]
x2 = A[1][3] - (A[1][2] * x1)
x3 = A[0][3] - (A[0][2] * x1) - (A[0][1] * x1)


for ls in A:
    for el in ls:
        print(f"{round(el, 3)}\t\t", end="")
    print('\n')
print(f"X1 = {round(x1, 3)}\tX2 = {round(x2, 3)}\t X3 = {round(x3, 3)}")
