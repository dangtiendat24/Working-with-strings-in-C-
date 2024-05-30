namespace Ex_String
{
    public class String()
    {
        // phương thức đảo chuỗi
        public string ReverseString(string inputString)
        {
            if(inputString == null)
            {
                return null;
            }
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }
        //phương thức đếm số lần xuất hiện của chuỗi
        public int CountOccurrences(string inputString, string searchString)
        {
            if(inputString == null || searchString == null || searchString == "") {
                return 0;
            }
            int count = 0;
            int index = 0;
            while((index = inputString.IndexOf(searchString, index)) != -1)
            {
                count++;
                index = (index + searchString.Length);
            }
            return count;
        }
        //phương thức thay thế chuỗi con
        public string ReplaceString(string inputString, string oldString, string newString) { 
            if(inputString == null ||  oldString == null || newString == null)
            {
                return null;
            }
            return inputString.Replace(oldString, newString);
        }
        //phương thức xoá khoảng cách
        public string RemoveWithSpace(string inputString)
        {
            if(inputString == null)
            {
                return null;
            }
            return inputString.Replace(" ", "");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = new String();
            //nhập chuỗi từ bàn phím
            Console.WriteLine("nhap mot chuoi: ");
            string userInput = Console.ReadLine();
            //nhập chuỗi cần tìm kiếm
            Console.WriteLine("nhap chuoi can tim: ");
            string searchString = Console.ReadLine();
            //nhập chuôi con cần thay thế
            Console.WriteLine("nhap chuoi can thay the: ");
            string oldSubstring = Console.ReadLine();
            //nhập chuỗi mới để thay thế
            Console.WriteLine("nhap chuoi moi de thay the: ");
            string newSubstring = Console.ReadLine();
            //gọi phương thức đảo chuỗi
            string reverse = str.ReverseString(userInput);
            //gọi phương thức tìm chuỗi
            int occurrences = str.CountOccurrences(userInput, searchString);
            //gọi phương thức thay thế chuôi con
            string modifiedString = str.ReplaceString(userInput, oldSubstring, newSubstring);
            //gọi phương thức xoá khoảng cách
            string modified1String = str.RemoveWithSpace(userInput);
            Console.WriteLine("chuoi ban dau: " + userInput);
            Console.WriteLine("chuoi sau khi dao: " +  reverse);
            Console.WriteLine($"chuoi '{searchString}' xuat hien {occurrences} lan trong chuoi '{userInput}'");
            Console.WriteLine("chuoi sau khi thay the: " +  modifiedString);
            Console.WriteLine("chuoi sau khi xoa khoang cach: " + modified1String);
        }
    }
}
