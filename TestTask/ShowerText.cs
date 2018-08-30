using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestTask {
	class ShowerText {

		static public String ShowText(String path) {
			String result = "";
			if (File.Exists(path)) {
				result += File.ReadAllText(path);
			}
			return result;
		}

		static public String ShowBytes(String path) {
			byte[] result;
			if (File.Exists(path)) {
				result = File.ReadAllBytes(path);
				StringBuilder hex = new StringBuilder(result.Length * 2);
				foreach (byte b in result)
					hex.AppendFormat("{0:x2}  ", b);
				return hex.ToString();
			}
			return "";
		}

		static public void SaveText(String text, String path) {
			FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
			byte[] byteText = Encoding.ASCII.GetBytes(text);
			stream.Write(byteText, 0, byteText.Length);
		}

		static public void SaveBytes(String text, String path) {
			/*Byte.Parse()
			FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
			byte[] byteText = Encoding.ASCII.GetBytes(text);
			stream.Write(byteText, 0, byteText.Length);*/
		}

	}
}
