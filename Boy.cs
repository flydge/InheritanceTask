namespace InheritanceTask
{
    public class Boy:Human
    {
        private const string _GENDER = "Boy";
        private string _girlfriendName;

        public Boy(int age, string name, double height, string girlfriendName) : base(age, name, height, _GENDER)
        {
            _girlfriendName = girlfriendName;
        }

        public override string Gender => _GENDER;

        public string GirlfriendName
        {
            get => _girlfriendName;
            set => _girlfriendName = value;
        }

        public override string ToString()
        {
            return base.ToString()+"GirlFriend:"+_girlfriendName;
        }
    }
}