using System;
using System.Linq;

namespace ValidationLibrary
{
    public static class StringOperation
    {
        public static string GetValidName(string nameToValidate)
        {
            if (nameToValidate == null)
            {
                throw new ArgumentException($"{nameof(nameToValidate)} is null!", nameof(nameToValidate));
            }

            var names = nameToValidate.Trim().Split(' ');
            for (int i = 0; i < names.Length; i++)
            {
                var chars = names[i].Trim().ToCharArray().
                    Where(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')).ToArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    chars[j] = j == 0 ? chars[j].ToString().ToUpper()[0] : chars[j].ToString().ToLower()[0];
                }

                names[i] = string.Join("", chars);
            }

            string returnName = string.Join(' ', names.Where(s => s.Any()));


            if (string.IsNullOrWhiteSpace(returnName))
            {
                throw new ArgumentException($"{nameof(nameToValidate)} is empty ot null!", nameof(nameToValidate));
            }
            else
            {
                return returnName;
            }
        }
    }
}