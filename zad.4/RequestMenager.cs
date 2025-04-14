using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._4
{
    internal class RequestMenager
    {
        HashSet<string> hash = new HashSet<string>();
        Queue<FileRequest> q = new Queue<FileRequest>();
        public void Add(FileRequest request)
        {

            if (!hash.Contains(request.Name))
            {
                hash.Add(request.Name); 
                q.Enqueue(request);  
            }
        }
        public void PrintRequests()
        {
            foreach (var request in q)
            {
                Console.WriteLine("Obrabotka na fail: "  + request);
            }
        }

    }
}
