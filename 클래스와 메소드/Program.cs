using System.Xml;
using 김승민;
using 김승민.메이플스토리;

namespace 클래스와_메소드
{
    class Program
    {
        static void PlayerTurn(Player player, Slime slime);
        static void Main(string[] args)
        {
            네임스페이스 ns = new 네임스페이스();
            ns.show();

            /*
             * 클래스 사용하는 방법
             * (이름공간.Slime) (클래스의 이름 변수) = new 메이플스토리.Slime();
             * 
             */


            김승민.메이플스토리.Slime slime = new 김승민.메이플스토리.Slime();
            slime.Name = "슬라임";
            slime.HP = 50;
            slime.AttackPower = 5;
            slime.MoveSpeed = 2.2f;
            slime.Show();

            김승민.메이플스토리.초록달팽이 snail = new 김승민.메이플스토리.초록달팽이();
            snail.Name = "초록달팽이";
            snail.Hp = 50;
            snail.AttackPower = 8;
            snail.MoveSpeed = 1.5f;
                
            김승민.메이플스토리.Player player = new 김승민.메이플스토리 Player();
            player.HP = 100;
            player.AttackPower = 10;

            slime.AttackPower(player);                                 //Attack() 메소드는 인자로 Player 객체를 받는다. Player
            slime.BeAttacked(player.AttackPower);                      //BeAttack() 메소드는 인자로 int 데이터를 받는다. (int)Player.AttackPower
            slime.Show();

            //Player.Show();

             white(true); // 무한 반복문
            { 
                PlayerTurn(player, slime); // 함수로 코드의 쓰임새를 쉽게 정리할 수 있다.

                slime.Attack(Player);
                Player.Show();
                slime.Shoew();
                //EnemyTurn(Player,slime);  //적이 플레이어를 대상으로 하는 행동 AI

                if (slime.HP <= 0)
                {
                    Console.WriteLine($"슬라임을 처치했습니다. 게임에서 승리했습니다.");
                    break;
                }

                if (Player.HP <= 0)
                {
                    Console.WriteLine($"플레이어가 사망했습니다. 게임에서 패배했습니다.");
                    break;
                }
            }
        }
    }
}
