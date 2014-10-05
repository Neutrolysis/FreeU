using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FreeU
{
	class TimeTable
	{
		List<Lecture> lectures = new List<Lecture>();
		Queue<Lecture> q = new Queue<Lecture>();
		String filename = "";
		StreamReader reader;
		public TimeTable(String filename)
		{
			reader = File.OpenText(filename);
			string buffer;
			buffer = reader.ReadLine();
			while ((buffer = reader.ReadLine()) != null)
			{
				Lecture lecture = new Lecture(buffer);
				lectures.Add(lecture);
				//Console.WriteLine(lecture.ToString());
			}
			refreshQueue();
		}
		public void refreshQueue()
		{
			foreach (Lecture l in lectures)
			{
				q.Enqueue(l);
			}
		}
		public bool hasNext()
		{
			return q.Count != 0;
		}
		public Lecture nextLecture()
		{
			return q.Dequeue();
		}
	}

}
