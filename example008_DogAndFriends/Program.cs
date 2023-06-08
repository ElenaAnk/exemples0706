int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
friend = 2;

while(distance>10)
{
    if(friend = 1)
    {
       time = distanse/(firstFriendSpeed + dogSpeed);
       friend = 2;
    }
    else
    {
        time = distanse/(secondFrienSpeed + dogSpeed);
        friend = 1;
    }
    distanse = distanse - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.WriteLine(count);