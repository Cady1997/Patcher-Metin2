using System;

namespace MT2.Patcher.Source
{
	internal class ListProcessor
	{
		public static void AddFile(string File)
		{
			Globals.File item = default(Globals.File);
			item.Name = File.Split(new char[]
			{
				' '
			})[0];
			item.Hash = File.Split(new char[]
			{
				' '
			})[1];
			item.Size = Convert.ToInt64(File.Split(new char[]
			{
				' '
			})[2]);
			Globals.Files.Add(item);
		}
	}
}
