using System;

class Node<T> where T : class
{
    public T Data;
    public Node<T> Next;

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList<T> where T : class
{
    private Node<T> head;

    public void Add(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node<T> current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public bool Contains(T item)
    {
        Node<T> current = head;

        while (current != null)
        {
            if (current.Data.Equals(item))
                return true;

            current = current.Next;
        }

        return false;
    }
    public void Remove(T item)
    {
        if (head == null)
            return;

        if (head.Data.Equals(item))
        {
            head = head.Next;
            return;
        }

        Node<T> current = head;

        while (current.Next != null)
        {
            if (current.Next.Data.Equals(item))
            {
                current.Next = current.Next.Next;
                return;
            }

            current = current.Next;
        }
    }
    public void Print()
    {
        Node<T> current = head;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public override string ToString() => $"Person: {Name}";
}

class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }

    public override string ToString() => $"Book: {Title}";
}

class Program
{
    static void Main()
    {
        LinkedList<string> stringList = new LinkedList<string>();
        stringList.Add("бебе");
        stringList.Add("ляля");

        Console.WriteLine("Строки:");
        stringList.Print();
        Console.WriteLine($"\nПоиск бебе - {stringList.Contains("бебе")}");
        stringList.Remove("ляля");
        Console.WriteLine("\nубираем ляля:");
        stringList.Print();

        LinkedList<Person> personList = new LinkedList<Person>();
        Person ivan = new Person("Иван");
        Person olga = new Person("Оля");
        personList.Add(ivan);
        personList.Add(olga);
        Console.WriteLine("\nЛюди:");
        personList.Print();
        Console.WriteLine($"\nпоиск Ивана - {personList.Contains(ivan)}");



        LinkedList<Book> bookList = new LinkedList<Book>();
        Book ViM = new Book("Война и мир");
        Book onegin = new Book("Онегин");
        bookList.Add(ViM);
        bookList.Add(onegin);
        Console.WriteLine("\nКниги:");
        bookList.Print();
        Console.WriteLine($"\nпоиск Онегина - {bookList.Contains(onegin)}");



        Console.ReadLine();
    }
}
