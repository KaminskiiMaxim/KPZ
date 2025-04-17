using System;

namespace RPGDecorator
{
    // Інтерфейс
    interface IHero
    {
        void Show();
    }

    // Класи
    class Warrior : IHero
    {
        public void Show()
        {
            Console.WriteLine("Це Воїн");
        }
    }

    class Mage : IHero
    {
        public void Show()
        {
            Console.WriteLine("Це Маг");
        }
    }

    class Palladin : IHero
    {
        public void Show()
        {
            Console.WriteLine("Це Паладин");
        }
    }

    // декоратор
    abstract class HeroDecorator : IHero
    {
        protected IHero hero;

        public HeroDecorator(IHero h)
        {
            hero = h;
        }

        public virtual void Show()
        {
            hero.Show();
        }
    }

    // зброя
    class Sword : HeroDecorator
    {
        public Sword(IHero h) : base(h) { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("  + меч");
        }
    }

    class Armor : HeroDecorator
    {
        public Armor(IHero h) : base(h) { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("  + броня");
        }
    }

    class Artifact : HeroDecorator
    {
        public Artifact(IHero h) : base(h) { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("  + артефакт");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо героя
            IHero hero = new Warrior();

            // інвентар
            hero = new Sword(hero);
            hero = new Armor(hero);
            hero = new Artifact(hero);

            // результат
            hero.Show();

            Console.ReadLine();
        }
    }
}
