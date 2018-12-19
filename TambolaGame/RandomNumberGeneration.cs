using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TambolaGame
{
    public class RandomNumberGeneration
    {
        App thisApp = (App)Application.Current;
        private Dictionary<int, string> dictionary = new Dictionary<int, string>();
        private HashSet<int> _fetchNumber = new HashSet<int>();
        private Random random = new Random();
        private readonly bool isRequired = false;
        public RandomNumberGeneration()
        {
            if (thisApp.IsRunningFirstTime)
            {
                NumberStringCollection();
            }
        }

        private int? NextNumber()
        {
            var i = default(int?);
            while (_fetchNumber.Count < 100 && !_fetchNumber.Add((int)(i = random.Next(1, 101)))) ;
            return i;
        }

        public string GetNumber()
        {
            var i = NextNumber();
            StringBuilder stringBuilder = new StringBuilder();
            if (i.HasValue)
            {
                if (i <= 15)
                    return $"T {i} {GetNumberString(i)}";
                if (i <= 30)
                    return $"A {i} {GetNumberString(i)}";
                if (i <= 45)
                    return $"M {i} {GetNumberString(i)}";
                if (i <= 60)
                    return $"B {i} {GetNumberString(i)}";
                if (i <= 75)
                    return $"O {i} {GetNumberString(i)}";
                if (i <= 90)
                    return $"L {i} {GetNumberString(i)}";
                if (i <= 100)
                    return $"A {i} {GetNumberString(i)}";
            }
            return string.Empty;
        }

        private string GetNumberString(int? i)
        {
            if (!dictionary.Any())
            {
                return "";
            }
            return dictionary.First(v => v.Key == i).Value;

        }

        private void NumberStringCollection()
        {
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");
            dictionary.Add(6, "Six");
            dictionary.Add(7, "Seven");
            dictionary.Add(8, "Eight");
            dictionary.Add(9, "Nine");
            dictionary.Add(10, "Ten");
            dictionary.Add(11, "Eleven");
            dictionary.Add(12, "Twelve");
            dictionary.Add(13, "Thirteen");
            dictionary.Add(14, "Fourteen");
            dictionary.Add(15, "Fifteen");
            dictionary.Add(16, "Sixteen");
            dictionary.Add(17, "Seventeen");
            dictionary.Add(18, "Eighteen");
            dictionary.Add(19, "Ninteen");
            dictionary.Add(20, "Twenty");
            dictionary.Add(21, "Twenty One");
            dictionary.Add(22, "Twenty Two");
            dictionary.Add(23, "Twenty Three");
            dictionary.Add(24, "Twenty Four");
            dictionary.Add(25, "Twenty Five");
            dictionary.Add(26, "Twenty Six");
            dictionary.Add(27, "Twenty Seven");
            dictionary.Add(28, "Twenty Eight");
            dictionary.Add(29, "Twenty Nine");
            dictionary.Add(30, "Thirty");
            dictionary.Add(31, "Thirty One");
            dictionary.Add(32, "Thirty Two");
            dictionary.Add(33, "Thirty Three");
            dictionary.Add(34, "Thirty Four");
            dictionary.Add(35, "Thirty Five");
            dictionary.Add(36, "Thirty Six");
            dictionary.Add(37, "Thirty Seven");
            dictionary.Add(38, "Thirty Eight");
            dictionary.Add(39, "Thirty Nine");
            dictionary.Add(40, "Fourty");
            dictionary.Add(41, "Fourty One");
            dictionary.Add(42, "Fourty Two");
            dictionary.Add(43, "Fourty Three");
            dictionary.Add(44, "Fourty Four");
            dictionary.Add(45, "Fourty Five");
            dictionary.Add(46, "Fourty Six");
            dictionary.Add(47, "Fourty Seven");
            dictionary.Add(48, "Fourty Eight");
            dictionary.Add(49, "Fourty Nine");
            dictionary.Add(50, "Fifty");
            dictionary.Add(51, "Fifty One");
            dictionary.Add(52, "Fifty Two");
            dictionary.Add(53, "Fifty Three");
            dictionary.Add(54, "Fifty Four");
            dictionary.Add(55, "Fifty Five");
            dictionary.Add(56, "Fifty Six");
            dictionary.Add(57, "Fifty Seven");
            dictionary.Add(58, "Fifty Eight");
            dictionary.Add(59, "Fifty Nine");
            dictionary.Add(60, "Sixty");
            dictionary.Add(61, "Sixty One");
            dictionary.Add(62, "Sixty Two");
            dictionary.Add(63, "Sixty Three");
            dictionary.Add(64, "Sixty Four");
            dictionary.Add(65, "Sixty Five");
            dictionary.Add(66, "Sixty Six");
            dictionary.Add(67, "Sixty Seven");
            dictionary.Add(68, "Sixty Eight");
            dictionary.Add(69, "Sixty Nine");
            dictionary.Add(70, "Seventy");
            dictionary.Add(71, "Seventy One");
            dictionary.Add(72, "Seventy Two");
            dictionary.Add(73, "Seventy Three");
            dictionary.Add(74, "Seventy Four");
            dictionary.Add(75, "Seventy Five");
            dictionary.Add(76, "Seventy Six");
            dictionary.Add(77, "Seventy Seven");
            dictionary.Add(78, "Seventy Eight");
            dictionary.Add(79, "Seventy Nine");
            dictionary.Add(80, "Eighty");
            dictionary.Add(81, "Eighty One");
            dictionary.Add(82, "Eighty Two");
            dictionary.Add(83, "Eighty Three");
            dictionary.Add(84, "Eighty Four");
            dictionary.Add(85, "Eighty Five");
            dictionary.Add(86, "Eighty Six");
            dictionary.Add(87, "Eighty Seven");
            dictionary.Add(88, "Eighty Eight");
            dictionary.Add(89, "Eighty Nine");
            dictionary.Add(90, "Ninty");
            dictionary.Add(91, "Ninty One");
            dictionary.Add(92, "Ninty Two");
            dictionary.Add(93, "Ninty Three");
            dictionary.Add(94, "Ninty Four");
            dictionary.Add(95, "Ninty Five");
            dictionary.Add(96, "Ninty Six");
            dictionary.Add(97, "Ninty Seven");
            dictionary.Add(98, "Ninty Eight");
            dictionary.Add(99, "Ninty Nine");
            dictionary.Add(100, "One Hundred");
            thisApp.IsRunningFirstTime = false;
        }
    }
}
