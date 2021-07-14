# Hi #
Thanks for applying to Emergent Software! We have a small code challenge for you to complete before your interview. We’ll review it and use it as a source of conversation about coding, so be prepared to talk about why you approached the problem the way you did and how you could have done it differently. 

Our goal with giving you homework is to allow you to write code in a low stress environment on your own computer. We realize we’re asking you to do this in your personal time, but we prefer this format over a long session of whiteboarding code in an interview.

You should not spend more than 4 hours on this challenge. If you reach the 4-hour mark and are not finished, just turn it in as-is and let us know what you would have done with more time.

# The Challenge #
An imaginary company stores a list of software products they use. They have stored the name and version of each product. They have asked us to create a simple website where users can type in a version number and receive a list of software products that are greater than the version they entered.

The software versions are stored as a string in the format [major version].[minor version].[patch]. You may see versions like “2”, “1.5”, or “2.12.4” (these are all valid inputs from the user as well). The period is only used as a separator and does not represent a decimal point – 1.5 does not mean one and a half. 

"2" == "2.0" == "2.0.0"
"2" < "2.0.1"
"2" < "2.1"
"2.0.1" < "2.1.0"

Lucky for you, they stored the software list as a C# object (provided below) that you can simply drop into your code – no need to call a database or REST service.

This site will be publicly available, so user authentication will not be required.

# Software Product List #

    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }

    public static class SoftwareManager
    {
        public static IEnumerable<Software> GetAllSoftware()
        {
            return new List<Software>
            {
                new Software
                {
                    Name = "MS Word",
                    Version = "13.2.1."
                },
                new Software
                {
                    Name = "AngularJS",
                    Version = "1.7.1"
                },
                new Software
                {
                    Name = "Angular",
                    Version = "8.1.13"
                },
                new Software
                {
                    Name = "React",
                    Version = "0.0.5"
                },
                new Software
                {
                    Name = "Vue.js",
                    Version = "2.6"
                },
                new Software
                {
                    Name = "Visual Studio",
                    Version = "2017.0.1"
                },
                new Software
                {
                    Name = "Visual Studio",
                    Version = "2019.1"
                },
                new Software
                {
                    Name = "Visual Studio Code",
                    Version = "1.35"
                },
                new Software
                {
                    Name = "Blazor",
                    Version = "0.7"
                }
            };
        }
    }