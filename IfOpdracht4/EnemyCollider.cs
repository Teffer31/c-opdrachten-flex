namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {

            //gebruik hier een || (OR)

            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying

            if (enemy.flying || enemy.swimmer) return enemy.flying == true;
            else return false;
            //vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
        }
        internal bool CanPassWater(Enemy enemy)
        {

            //gebruik hier een || (OR)

            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying

            if (enemy.incoporial || enemy.flying) return enemy.swimmer == true;
            else return false;  
            //vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian,swimmer) true is;
        }
    }
}