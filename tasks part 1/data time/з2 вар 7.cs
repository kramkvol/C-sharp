using System;
namespace ConsoleApp32
{
    struct SportGamer
    {
        public string CountryName;
        public string TeamName;
        public string PlayerName;
        public int PlayerNum;
        public int PlayerAge;
        public double PlayerHeight;
        public double PlayerWeight;
        public SportGamer(string CountryName, string TeamName, string PlayerName, int PlayerNum, int PlayerAge, double PlayerHeight, double PlayerWeight)
        {
            this.CountryName = CountryName;
            this.TeamName = TeamName;
            this.PlayerName = PlayerName;
            this.PlayerNum = PlayerNum;
            this.PlayerAge = PlayerAge;
            this.PlayerHeight = PlayerHeight;
            this.PlayerWeight = PlayerWeight;
        }

        public override string ToString()
        {
            return (string.Format(" ������������ ������ {0};\n �������� �������{1};\n" +
                " ��� ������ {2};\n ������� ����� {3};\n" + " ������� {4};\n" +
                " ���� {5};\n ��� {6};\n ", CountryName, TeamName, PlayerName,
                PlayerNum, PlayerAge, PlayerHeight, PlayerWeight));
        }
    };
    class Class1
    {
        static void Main()
        {
            SportGamer a = new SportGamer ("������", " �������������", "������� �.�.", 1, 30, 1.87, 75);
            SportGamer b = new SportGamer("�����", " ������������", " ������.�.", 2, 29, 1.90, 74);
            SportGamer c = new SportGamer("�������", "��������������", "����� �.�.", 3, 31, 1.78, 73);
            SportGamer d = new SportGamer("��������", "���������������", "���� �.�.", 4, 30, 1.91, 77);
            SportGamer[] arr = { a, b, c, d};
            int min = arr[0].PlayerAge;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].PlayerAge < min)
                {
                    min = arr[i].PlayerAge;
                }
            }
            Console.WriteLine(min.ToString());
            Console.ReadKey();
        }
    }
}
 