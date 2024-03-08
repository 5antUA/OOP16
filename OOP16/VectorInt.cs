using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

public class VectorInt
{
    private int[] Vector; // масив
    public int Length; // фізична ємкість масива
    public int Count; // фактична ємкість масива

    // конструктор
    public VectorInt(int capacity)
    {
        if (capacity < 0)
            capacity = 0;

        Vector = new int[capacity];
        Length = capacity;
        Count = 0;
    }

    // Налаштування властивостей
    public int this[int index]
    {
        // отримування значення за вказаним індексом
        get
        {
            if (index >= Vector.Length)
                throw new IndexOutOfRangeException("GetError: Вихід за межі масиву!");

            return Vector[index];
        }
        // вставка значення за вказаним індексом
        set
        {
            if (index >= Vector.Length)
                throw new IndexOutOfRangeException("SetError: Вихід за межі масиву!");

            Vector[index] = value;
        }
    }

    // Додавання елемента в кінець списку
    public void Add(int value)
    {
        if (this == null || Length == 0)
            throw new NullReferenceException();

        Vector[Count] = value;
        Count++;
    }


    // Перевантаження оператора '+'
    public static VectorInt operator +(VectorInt first, VectorInt second)
    {
        if (first.Length != second.Length)
            throw new Exception();

        var result = new VectorInt(first.Length);
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = first[i] + second[i];
        }
        return result;
    }

    // Перевантаження оператора '-'
    public static VectorInt operator -(VectorInt first, VectorInt second)
    {
        if (first.Length != second.Length)
            throw new Exception();

        var result = new VectorInt(first.Length);
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = first[i] - second[i];
        }
        return result;
    }

    // Метод для множення вектора на скаляр
    public VectorInt Multiply(int skalar)
    {
        if (this == null)
            throw new NullReferenceException();

        var result = new VectorInt(Length);
        for (int i = 0; i < Length; i++)
        {
            result[i] = Vector[i] * skalar;
        }
        result.Count = this.Count;
        return result;
    }

    // Метод для ділення вектора на скаляр
    public VectorInt Divide(int skalar)
    {
        if (skalar == 0)
            throw new ArgumentException();

        if (this == null)
            throw new NullReferenceException();

        var result = new VectorInt(Length);
        for (int i = 0; i < Length; i++)
        {
            result[i] = Vector[i] / skalar;
        }
        result.Count = this.Count;
        return result;
    }

    // "друк" елементів масиву
    public string PrintVector()
    {
        string result = string.Empty;
        for (int i = 0; i < Count; i++)
        {
            result += $"{Vector[i]}; ";
        }
        return result;
    }
}
