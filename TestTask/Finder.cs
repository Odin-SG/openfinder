using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace TestTask {
	class Finder {
		private String folder;
		private String templName;
		private String[] files;
		private String[] dirs;
		private List<String> tempList = new List<string>();
		private List<String> namesList = new List<string>();
		public List<String> TempList {
			get {
				return tempList;
			}
		}
		public List<String> NamesList {
			get {
				return namesList;
			}
		}
		public String Folder {
			get {
				return folder;
			}
		}

		public Finder(String path, String name = "*") {
			folder = path; templName = name;
		}

		public String[] GetListFiles() {
            files = Directory.GetFiles(folder, templName);
			return files;
		}

		public String[] GetListFolders() {
			dirs = Directory.GetDirectories(folder);
			return dirs;
		}

		public String[] GetAll() {
			tempList.AddRange(GetListFiles(folder));
			AllFilesGet(folder);
			return tempList.ToArray<String>();
		}

		public String[] cutPath() {
			tempList.ForEach(Cut);
			return namesList.ToArray<String>();
		}


		private String[] GetListFiles(String inFolder) {
            Regex reg = new Regex(templName);
            files = Directory.GetFiles(inFolder, "*").Where(path => reg.IsMatch(path)).ToArray<string>();
            return files;
		}

		private String[] GetListFolders(String inFolder) {
			dirs = Directory.GetDirectories(inFolder);
			return dirs;
		}

		private String[] AllFilesGet(String currFolder) {
			foreach (String fol in GetListFolders(currFolder)) {
				tempList.Add(fol);
				tempList.AddRange(AllFilesGet(fol));
			}
			return GetListFiles(currFolder);
		}

		private void Cut(String path) {
			namesList.Add(path.Remove(0, folder.Length+1));
		}
	}
}
