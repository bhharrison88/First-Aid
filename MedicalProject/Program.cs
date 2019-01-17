using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is designed to give basic life saving instructions. \n "+
                "In the event of an emergency ALWAYS call 911");
            Console.ReadLine();
            Console.Clear();
           menu: Console.WriteLine("Please select from the following: \n"+
                " 1.) Choking \n 2.) Shock \n 3.) Bullet wound \n 4.) Hypothermia \n "+
                "5.) Severe Bleeding \n \n \n \n \n \n \n 9.) Exit");
           int x= int.Parse(Console.ReadLine());
            Console.Clear();
            if (x == 1)
            {
                Console.WriteLine("Choking happens when someone's airway suddenly gets blocked, either fully or"+
                    " partly, so they can't breathe. \n This information applies to adults and children over 1 year old.");
                Console.ReadLine();
                Console.WriteLine("Mild choking: encourage them to cough \n \n Severe choking:"+
                    "back blows and abdominal thrusts \n \n Where choking is severe, the person " + 
                    "won't be able to speak, cry, cough or breathe.\n Without help, they'll eventually become unconscious. \n "+
                    "\n To carry out a back blow on an adult or child over 1 year old: \n \n "+
    "Stand behind them and slightly to one side. \n \n Support their chest with 1 hand. \n Lean them forward so the object blocking their airway will come out of their mouth, \n \n  rather than moving further down." +
    "Give up to 5 sharp blows between their shoulder blades \n \n with the heel of your hand.The heel is between the palm \n \n of your hand and your wrist." +
    "Check if the blockage has cleared. \n \n If not, give up to 5 abdominal thrusts.");
                Console.Clear();
                Console.WriteLine("Abdominal thrusts \n Don't give abdominal thrusts to babies " +
                    "under 1 year old or pregnant women. \n" +
                    "To carry out an abdominal thrust: \n" +
                    "Stand behind the person who's choking. \n" +
                    "Place your arms around their waist and bend them forward. \n" +
                    "Clench 1 fist and place it right above their belly button. \n" +
                    "Put the other hand on top of your fist and pull sharply inwards and upwards. \n" +
                    "Repeat this movement up to 5 times.");
                Console.ReadLine();
                Console.Clear();
                goto menu;
                            }






            if (x == 2)
            {
                Console.WriteLine("Shock \n Shock (not to be confused with emotional shock)" +
                    " is a life-threatening condition which \n happens when the body isn’t" +
                    " getting enough flow of blood. \n " +
              " This means that the cells don’t get enough oxygen to enable them to work properly, " +
              "\n which can lead to damage of the vital organs like the brain and the heart. \n \n "+
       "Shock can be caused by anything that reduces the flow of blood, including: \n• heart problems, such as a" +
       " heart attack, or heart failure \n • severe internal or external bleeding \n • loss of body fluids, from dehydra" +
       "tion, diarrhoea, vomiting or burns \n • severe allergic reactions and severe infecti" +
       "on \n If someone has any of the conditions above, which can reduce the " +
       "circulation or blood flow, \n they could develop shock, so you may need to treat them " +
       "for this condition as well. \n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(" What to look for – shock \n If you think somebody could be suffering " +
                    "from shock, there are seven key things to look for:\n 1.  1.Paleness of the " +
                    "face(pallor)\n 2.  2.Cold, clammy skin \n 3.  3.Fast, shallow breath" +
    "ing\n 4.  4.Fast, weak pulse\n 5.  5.Yawning or sighing\n 6.  6.Confusion\n 7.  7.Loss of resp" +
    "onse(in extreme cases) \n \n What you need to do – shock \n If they are showing signs of sho" +
    "ck:\n• Lay them down with their head low and legs raised and supported, to increase the flow of \n blood to " +
    "their head.Do not raise an injured leg.\n • Loosen any tight clothing around the neck, chest and" +
    " waist to make sure it doesn’t \n constrict their blood flow \n • Fear and pain can make shock worse, b" +
    "y increasing the body’s demand for oxygen, so \n while you wait for help to arrive, it’s important to keep them " +
    "comfortable, \n warm and calm.Do this by covering them with a coat or blanket \n and comforting and reassuring them \n• Keep " +
    "checking their breathing, pulse and level of response. \n• If they become " +
    "unresponsive at any point, open their airway, check their breathing, and\n  " +
    "prepare to treat someone who has become unresponsive.");
                Console.ReadLine();
                Console.Clear();
                goto menu;
            }
            if (x == 3)
            {
                Console.WriteLine("Bullet wound \n STAY SAFE \n Get to safety!You can't help anyone" +
                    " if you get hurt yourself. If the patient can walk or run,\n take them with you. " +
                    "In the case of an accidental shooting, make sure the gun is secured.\n");
                Console.Clear();
                Console.WriteLine("Treatment Steps \n 1.Stop the bleeding\n 1.Pressure is the" +
    " most important thing.If blood is coming out of a hole, put a lot of pressure \n on it.For particula" +
    "rly bad bleeding, don't be afraid to use your knee and really lean on \n the wound hard. \n 2.Use" +
    " a dressing(gauze, towels, shirts, etc.) Dressings help the blood to clot and seal the \n wound. \n 3.Use" +
    " a tourniquet if you can.Professional tourniquets are great, but using them properly \n takes practice.It " +
    "should be very uncomfortable if it's on correctly—maybe even painful. \n Improvised tourniquets fail often." +
    " So, if you don't have a commercial version, just hold \n pressure and really lean into it. \n 2.If the patien" +
    "t is not breathing, begin CPR. \n 3.Seal gunshot wounds to the chest " +
    "with some type of plastic to keep air from being sucked into \n the wound.This helps prevent the develo" +
    "pment of a collapsed lung.If the patient begins \n complaining of worsening shortness of breath after sealin" +
    "g the wound, remove the seal. \n");
                Console.ReadLine();
                Console.Clear();
                goto menu;
            }

            if (x == 4)
            {
                Console.WriteLine("Hypothermia \n Treatment of Hypothermia \n Treatment is necessary when people s" +
                    "uffer from hypothermia.Remember that the \n ground will draw heat from the victim’s body.Always" +
                    " insulate the victim from the \n ground and from wet places.The treatments below will help raise" +
                    " the core body \n temperature slowly and evenly.Never give alcohol to a person suffering from " +
                    "\n hypothermia! \n");
                Console.Clear();
                Console.WriteLine("Mild Hypothermia \n •	Cover the victim’s head. \n •	Remove wet cloth" +
                    "es; provide dry clothes. \n•	Provide warm liquids(if victim is conscious). \n " +
                    "•	Provide rest near a heat source. \n Severe Hypothermia \n•	Send for qualified medical aid." +
                    " \n•	Provide warm liquids(if victim is conscious). \n•	Handle gen" +
      "tly!The victim is very sensitive during this stage. \n•	Cover the victim’s head. \n" +
      "•	Cover the victim with good insulation. \n•	Place warm objects near the victim" +
      "’s chest, neck, and head.Use your own body(skin-to - \n skin, if necessary) to help warm the victim. \n" +
      "•	Continue to provide warmth until an EMT, doctor, or other qualified medical aid arrives." +
      " \n Don’t give up even if the victim appears to be dead! \n•	Watch for signs of shock. \n");
                Console.ReadLine();
                Console.Clear();
                goto menu;
            }

            if (x == 5)
            {
                Console.WriteLine("Severe Bleeding \n \n For severe bleeding, take these first-aid step" +
                    "s and reassure the injured person. \n\n1.Remove any clothing or debris on the wound" +
                    ".Don't remove large or deeply \n embedded objects. Don't probe the wound or attempt to " +
                    "clean it yet.Your first job\n is to stop the bleeding.Wear disposable protective gloves if available.\n \n2.Stop the blee" +
                    "ding. Place a sterile bandage or clean cloth on the wound. Press the \n bandage firmly with your palm to control bleeding.Apply consta" +
                    "nt pressure until \n the bleeding stops. Maintain pressure by binding the wound with a thick \n bandage or a piece of clean cloth. Don't put direct" +
                    " pressure on an eye injury or \n embedded object. \nSecure the bandage with ad" +
                    "hesive tape or continue to maintain pressure with your \n hands. If possib" +
                    "le, raise an injured limb above the level of the heart. \n\n3.Help the injure" +
                    "d person lie down.If possible, place the person on a rug or \n blanket to prevent los" +
                    "s of body heat. Calmly reassure the injured person. \n\n4.Don't remove the gauze " +
                    "or bandage. If the bleeding seeps through the gauze or \n other cloth on the wound, add anoth" +
                    "er bandage on top of it. And keep pressing \n firmly on the area. \n\n5.Tourniquets: A tourn" +
                    "iquet is effective in controlling life-threatening bleeding from a \n limb. Apply a tourniq" +
                    "uet if you're trained in how to do so. When emergency help \n arrives, explain how long th" +
                    "e tourniquet has been in place. \n\n6.Immobilize the injured body part as much as possible.Leave" +        
                   " the bandages in \n place and get the injured person to an emergency room as soon as possible. \n");
                Console.ReadLine();
                Console.Clear();
                goto menu;
            }

            if (x == 9) {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
                
            }
        }
    }
}
