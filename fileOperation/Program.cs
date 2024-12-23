using System.IO;
StreamWriter sw = new StreamWriter("ram.txt");
sw.Write("firstline\n");
sw.Write("secondline\n");
sw.Write("thirdline\n");
sw.Flush();
sw.Close();