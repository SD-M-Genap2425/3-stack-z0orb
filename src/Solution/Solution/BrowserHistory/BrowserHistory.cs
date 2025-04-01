using System;
using System.Collections.Generic;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; }

        public Halaman(string url)
        {
            URL = url;
        }
    }

    public class StackNode
    {
        public Halaman Data { get; }
        public StackNode Next { get; set; }

        public StackNode(Halaman data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Stack
    {
        private StackNode top;

        public Stack()
        {
            top = null;
        }

        public void Push(Halaman halaman)
        {
            var newNode = new StackNode(halaman);
            newNode.Next = top;
            top = newNode;
        }

        public Halaman Pop()
        {
            if (top == null) return null;

            var poppedNode = top;
            top = top.Next;
            return poppedNode.Data;
        }

        public Halaman Peek()
        {
            return top?.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public List<string> GetAllUrls()
        {
            var urls = new List<string>();
            var current = top;
            while (current != null)
            {
                urls.Add(current.Data.URL);
                current = current.Next;
            }
            urls.Reverse(); // Reverse to maintain order from oldest to newest
            return urls;
        }
    }

    public class HistoryManager
    {
        private readonly Stack historyStack;

        public HistoryManager()
        {
            historyStack = new Stack();
        }

        public void KunjungiHalaman(string url)
        {
            var halaman = new Halaman(url);
            historyStack.Push(halaman);
            Console.WriteLine($"Mengunjungi halaman: {url}");
        }

        public string Kembali()
        {
            var current = historyStack.Pop();
            if (current == null)
            {
                Console.WriteLine("Tidak ada halaman sebelumnya.");
                return "Tidak ada halaman sebelumnya.";
            }

            var previous = historyStack.Peek();
            Console.WriteLine("Kembali ke halaman sebelumnya...");
            return previous?.URL ?? "Tidak ada halaman sebelumnya.";
        }

        public string LihatHalamanSaatIni()
        {
            var current = historyStack.Peek();
            return current?.URL ?? "Tidak ada halaman saat ini.";
        }

        public void TampilkanHistory()
        {
            var urls = historyStack.GetAllUrls();
            foreach (var url in urls)
            {
                Console.WriteLine(url);
            }
        }
    }
}