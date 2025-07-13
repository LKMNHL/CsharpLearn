//Console.WriteLine("Hello, world");

using System; // System 이라는 네임스페이스에 정의된 기능 사용하기 위해

// 네임 스페이스: 특정 클래스가 어디에 속했는지...
// 변수 이름 짓기 편하다. 어떤 것의 print 기능! 저떤 것의 print 기능!
namespace MyFirstApp
{
    // MyFirstApp의 네임스페이스에 속한 것들...

    // 클래스. 변수+메소드로 구성
    class Program
    {
        // Main은 모든 프로그램이 흐르는 중심. 한개만 있어야 함.
        // static 선언. 프로그램 시작 시 해당 클래스가 메모리에 올라감.
        // void: 출력되는 형태가 없을 때.
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(num);
            // using System을 선언하지 않았다면
            // System.Console.WriteLine(num); 으로 작성해야 함.
            Console.WriteLine("Hello, world");
        }
    }
}
