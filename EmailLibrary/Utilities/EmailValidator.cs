using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailLibrary.Utilities
{
    public static class EmailValidator
    {
        private static string _recipientName;
        private static string _domainName;
        private static string _topLevelDomainName;

        private static List<char> _specialCharacters = new List<char>()
        {
            '!', '#', '$', '%', '&', '\'', '*', '+', '-', '/', '=', '?', '^', '_', '`', '{', '.', '|', '}'
        };


        public static bool Validate(string emailAddress)
        {

            bool output = false;
            if(emailAddress != null && BreakUpEmail(emailAddress))
            {
                if(ValidateRecipientName() && ValidateDomainName() && ValidateTopLevelDomain())
                {
                    output = true;
                }
            }
            return output;
        }

        private static bool ValidateRecipientName()
        {
            bool output = false;
            bool startsWithSpecial = false;
            bool specialOccursMoreThanOnce = false;

            if(_recipientName.Length > 0 && _recipientName.Length <= 64)
            {
                //Check if name starts with special character
                foreach (var character in _specialCharacters)
                {
                    int count = 0;
                    if(_recipientName[0] != character)
                    {
                        foreach (var letter in _recipientName)
                        {
                            if(letter == character)
                            {
                                count++;
                                if(count > 1)
                                {
                                    specialOccursMoreThanOnce = true;
                                    break;
                                }
                            }
                        }
                        if(specialOccursMoreThanOnce == false)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        startsWithSpecial = true;
                        break;
                    }
                }
                if (startsWithSpecial || specialOccursMoreThanOnce)
                {
                    return output;
                }
                else
                {
                    //If all the checks are done and valid then it is a valid recipient name
                    output = true;
                }
            }
            return output;
        }

        private static bool ValidateDomainName()
        {
            bool output = false;
            bool hasInvalidCharacter = false;

            if(_domainName != null)
            {
                if(_domainName.Length > 0 && _domainName.Length <= 253)
                {
                    foreach (var letter in _domainName)
                    {
                        foreach (var character in _specialCharacters)
                        {
                            if(letter == '-' || letter == '.')
                            {
                                break;
                            }
                            else
                            {
                                if(letter == character)
                                {
                                    hasInvalidCharacter = true;
                                    break;
                                }
                            }
                        }
                        if (hasInvalidCharacter)
                        {
                            break;
                        }
                    }
                }
                if (hasInvalidCharacter)
                {
                    return output;
                }
                else
                {
                    output = true;
                }
            }
            return output;
        }

        private static bool ValidateTopLevelDomain()
        {
            if(_topLevelDomainName != null)
            {
                return true;
            }
            return false;
        }

        private static bool BreakUpEmail(string emailAddress)
        {
            bool output = false;
            var parts = emailAddress.Split('@');
            if (parts.Length == 2)
            {
                var domainParts = parts[1].Split('.');
                if(domainParts.Length <= 2)
                {
                    _recipientName = parts[0];
                    _domainName = domainParts[0];
                    _topLevelDomainName = domainParts[1];
                    output = true;
                }
            }

            return output;
        }
    }
}
