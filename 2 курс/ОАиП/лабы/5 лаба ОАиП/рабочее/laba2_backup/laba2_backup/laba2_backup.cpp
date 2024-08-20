// laba5.cpp : This file contains the 'main' function. Program execution begins and ends there.

using namespace std;
#include <iostream>
#include <random> // для 1-го задания (2 n 3)

void task_1(int(*pointMatrix)[2], int* pSum, int* pMult1, int* pMult2);
int task_2(int(*pMatrix_OG), int size);
void task_3(double** pSource, int rowsM, int colN);

int main()
{
	//setlocale(LC_ALL, "Russian");
	start:
	int num;
	cout << "Задание: ";
	cin >> num;
	switch (num)
	{
	case 1:
	{
		random_device rd; //the random engine itself. 
		uniform_int_distribution <int> dist(1, 10); //setting the distibution (distance), can change the types to double etc(??)
		int matrix[2][2] = {};
		int* pMatrix = &matrix[2][2];
		int det = 0, mult1 = 1, mult2;
		cout << "Матрица: " << endl;
		for (int i = 0; i < 2; i++) //row
		{
			for (int j = 0; j < 2; j++) //column
			{
				matrix[i][j] = dist(rd);
				cout << matrix[i][j] << " ";
			}
			cout << "\n";
		};	
		task_1(matrix, &det, &mult1, &mult2);
		cout << "Определитель =  " << det << endl;
		cout << "Произведение диагональных элементов матрицы: " << mult1 << " и " << mult2 << endl;
		break;
	}

	case 2:
	{
		random_device rd;
		uniform_int_distribution <int> dist(1, 10);
		int m, count;
		cout << "Введите длинну массива: ";
		cin >> m;
		int* matrix_OG;
		matrix_OG = new int[m];
		cout << "Массив: " << endl;
		for (int i = 0; i < m; i++)
		{
			matrix_OG[i] = dist(rd);
			cout << matrix_OG[i] << " ";
		};
		cout << endl;
		int count_1 = task_2(matrix_OG, m);
		cout << "Наибольший э-т массива: " << *matrix_OG << ". Стоит под номером " << count_1 + 1 << endl;
		break;
	}

	case 3:
	{
		random_device rd;
		uniform_real_distribution <double> dist(-2.0, 2.0);
		int m, n;
		cout << "Введите число строк (m): ";
		cin >> m;
		cout << "Введите число столбцов (n): ";
		cin >> n;
		double** matrix_OG = new double* [m]; // создание основной матрицы и транспонированной матрицы. Вторая пустая
		for (int i = 0; i < m; i++)
		{
			matrix_OG[i] = new double[n];
		}

		cout << "Матрица: " << endl;
		for (int i = 0; i < m; i++) //row
		{
			for (int j = 0; j < n; j++) //column
			{
				matrix_OG[i][j] = dist(rd);
				cout << matrix_OG[i][j] << " ";
			}
			cout << "\n";
		};
		task_3(matrix_OG, m, n);
		break;
	}

	default:
		cout << "invalid input. try again" << endl;
		goto start;
		break;
	}
}

// вычисляющую определитель и произведение диагональных элементов матрицы второго порядка
// Расчет должен производиться в функции, которая получает данные по указателю и возвращает результат по указателю.
void task_1(int(*pointMatrix)[2], int* pSum, int* pMult1, int* pMult2) //function that returns void, as we want to modify the values passed by pointers
{
	int tempDet = 0, tempSum = 0, tempMult1 = 1, tempMult2 = 1;
	tempMult1 = pointMatrix[0][0] * pointMatrix[1][1];
	tempMult2 = pointMatrix[0][1] * pointMatrix[1][0];
	tempDet = tempMult1 - tempMult2;
	*pSum = tempDet;
	*pMult1 = tempMult1;
	*pMult2 = tempMult2;
}


// определяющую максимальный(-ые) элемент одномерного массива, и выводящую его номер
// При вводе/выводе элементов использовать индексы, а обработку элементов массива осуществлять с помощью указателей
// Расчет должен производиться в функции, в которую массив передается по указателю
int task_2(int(*pMatrix_OG), int size)
{
	int count = 0;
	int max_value = pMatrix_OG[0];
	for (int i = 0; i < size; i++)
	{
		if (pMatrix_OG[i] > max_value)
		{
			max_value = pMatrix_OG[i];
			count++;
		}
	}

	pMatrix_OG[0] = max_value;
	return count;
}

// выполняющую транспонирование неквадратной матрицы.
// Матрицы должны храниться в памяти в виде двумерного динамического массива, размерности матриц вводятся пользователем с клавиатуры.
// Предусмотреть генерацию значений матриц как случайных вещественных чисел в диапазоне от -2.0 до 2.0.
void task_3(double** pSource, int rowsM, int colN)
{
	// строки m, столбцы n	
	// выделяем память для матриц
	double** Transported = new double* [colN];
	for (int i = 0; i < colN; i++)
	{
		Transported[i] = new double[rowsM];
		for (int j = 0; j < rowsM; j++)
		{
			Transported[i][j] = pSource[j][i];
		}
	}

	cout << "Транспонированная матрица: " << endl;
	for (int i = 0; i < colN; i++) //row
	{
		for (int j = 0; j < rowsM; j++) //column
		{
			cout << Transported[i][j] << " ";
		}
		cout << endl;
	};

}