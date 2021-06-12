using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CRUD_ASP_PROJECT.Models
{
    public partial class MyDataBaseContext : DbContext
    {
       
        public MyDataBaseContext(DbContextOptions<MyDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnimeModel> Animes { get; set; }

        
        //Seed
        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<AnimeModel>().HasData(new AnimeModel
                                                                     { Id = 1,
                                                                       Title = "Tate no Yuusha no Nariagari",
                                                                       Story = "The Four Cardinal Heroes are a group of ordinary men from modern-day Japan summoned to the kingdom of Melromarc to become its saviors. Melromarc is a country plagued by the Waves of Catastrophe that have repeatedly ravaged the land and brought disaster to its citizens for centuries. The four heroes are respectively bestowed a sword, spear, bow, and shield to vanquish these Waves. Naofumi Iwatani, an otaku, becomes cursed with the fate of being the Shield Hero. Armed with only a measly shield, Naofumi is belittled and ridiculed by his fellow heroes and the kingdom's people due to his weak offensive capabilities and lackluster personality. When the heroes are provided with resources and comrades to train with, Naofumi sets out with the only person willing to train alongside him, Malty Melromarc. He is soon betrayed by her, however, and becomes falsely accused of taking advantage of her. Naofumi then becomes heavily discriminated against and hated by the people of Melromarc for something he didn't do. With a raging storm of hurt and mistrust in his heart, Naofumi begins his journey of strengthening himself and his reputation. Further along however, the difficulty of being on his own sets in, so Naofumi buys a demi-human slave on the verge of death named Raphtalia to accompany him on his travels. As the Waves approach the kingdom, Naofumi and Raphtalia must fight for the survival of the kingdom and protect the people of Melromarc from their ill-fated future.",
                                                                       Image = "https://cdn.myanimelist.net/images/anime/1490/101365.jpg",
                                                                       Video = "https://www.youtube.com/embed/cmwqlMnGDzA?autoplay=1"});
            modelBuilder.Entity<AnimeModel>().HasData(new AnimeModel
                                                                     { Id = 2,
                                                                       Title = "Black Clover",
                                                                       Story = "Asta and Yuno were abandoned at the same church on the same day. Raised together as children, they came to know of the Wizard King—a title given to the strongest mage in the kingdom—and promised that they would compete against each other for the position of the next Wizard King. However, as they grew up, the stark difference between them became evident. While Yuno is able to wield magic with amazing power and control, Asta cannot use magic at all and desperately tries to awaken his powers by training physically. When they reach the age of 15, Yuno is bestowed a spectacular Grimoire with a four-leaf clover, while Asta receives nothing. However, soon after, Yuno is attacked by a person named Lebuty, whose main purpose is to obtain Yuno's Grimoire. Asta tries to fight Lebuty, but he is outmatched. Though without hope and on the brink of defeat, he finds the strength to continue when he hears Yuno's voice. Unleashing his inner emotions in a rage, Asta receives a five-leaf clover Grimoire, a Black Clover giving him enough power to defeat Lebuty. A few days later, the two friends head out into the world, both seeking the same goal—to become the Wizard King!",
                                                                       Image = "https://upload.wikimedia.org/wikipedia/en/9/95/BCS4KeyVisual.jpg",
                                                                       Video = "https://www.youtube.com/embed/MH4pWlX4LqI?autoplay=1"});
            
            modelBuilder.Entity<AnimeModel>().HasData(new AnimeModel
                                                                     { Id = 3,
                                                                       Title = "Death Note",
                                                                       Story = "Ryuk, a god of death, drops his Death Note into the human world for personal pleasure. In Japan, prodigious high school student Light Yagami stumbles upon it. Inside the notebook, he finds a chilling message: those whose names are written in it shall die. Its nonsensical nature amuses Light; but when he tests its power by writing the name of a criminal in it, they suddenly meet their demise. Realizing the Death Note's vast potential, Light commences a series of nefarious murders under the pseudonym  Kira,  vowing to cleanse the world of corrupt individuals and create a perfect society where crime ceases to exist. However, the police quickly catch on, and they enlist the help of L—a mastermind detective—to uncover the culprit. Death Note tells the thrilling tale of Light and L as they clash in a great battle-of-minds, one that will determine the future of the world.",
                                                                       Image = "https://cdn.europosters.eu/image/750/posters/death-note-duo-i28405.jpg",
                                                                       Video = "https://www.youtube.com/embed/tJZtOrm-WPk?autoplay=1"
            });

            modelBuilder.Entity<AnimeModel>().HasData(new AnimeModel
                                                                     { Id = 4,
                                                                       Title = "Kingdom",
                                                                       Story= "Following the successful Sanyou campaign, the Qin army, including 1,000-Man Commander Li Xin, inches ever closer to fulfilling King Ying Zheng's dream of unifying China. With a major geographical foothold in the state of Wei now under its control, Qin sets its sights eastward toward the remaining warring states. Meanwhile Li Mu—an unparalleled strategist and the newly appointed prime minister of the state of Zhao—has taken advantage of Zhao's temporary truce with Qin to negotiate with the other states without interruption. Seemingly without warning, Ying Zheng receives news that armies from the states of Chu, Zhao, Wei, Han, Yan, and Qi have crossed into Qin territory. Realizing too late the purpose behind Li Mu's truce with Qin, Zheng quickly gathers his advisors to devise a plan to address the six-state coalition army on their doorstep. For the first time in history, the state of Qin faces complete destruction and must use every resource and strategy at their disposal to prevent themselves from being wiped off the map.",
                                                                       Image = "https://cdn.myanimelist.net/images/anime/1443/111830.jpg",
                                                                       Video = "https://www.youtube.com/embed/CasaH4vvYEw?autoplay=1"
            });

            modelBuilder.Entity<AnimeModel>().HasData(new AnimeModel
                                                                     { Id = 5,
                                                                       Title = "Yuukoku no Moriarty",
                                                                       Story="Great Britain is ablaze with news of a so-called Lord of Crime, a criminal mastermind responsible for the downfall of several unruly nobles. In truth, the Lord of Crime is not an individual, but rather a group consisting of William James Moriarty and his two brothers, Louis and Albert. Together, they wish to destroy everything rotten about their current world and create a new, fair society for all. To accomplish their goal, they must commit criminal acts, which the great detective Sherlock Holmes and his partner, John H. Watson, cannot abide by. A dangerous cat and mouse game begins between the Lord of Crime and Sherlock, with each trying to outwit the other. Yet Sherlock, despite his skills, has no idea that his foe is right under his nose. Involved with both parties is a woman named Irene Adler, who is as beautiful as she is cunning. No stranger to scandal, Irene has embroiled herself in one that may be too big even for her, as the classified documents she stole could shake the very foundations of the British Empire. Can Irene be saved, or does a deadly future await her?",
                                                                       Image = "https://cdn.myanimelist.net/images/anime/1200/111522.jpg",
                                                                       Video = "https://www.youtube.com/embed/DeI3yNsyMKI?autoplay=1"
            });

            modelBuilder.Entity<AnimeModel>().HasData(new AnimeModel
                                                                     { Id = 6,
                                                                       Title = "One Piece",
                                                                       Story ="Gol D. Roger was known as the Pirate King, the strongest and most infamous being to have sailed the Grand Line. The capture and execution of Roger by the World Government brought a change throughout the world. His last words before his death revealed the existence of the greatest treasure in the world, One Piece. It was this revelation that brought about the Grand Age of Pirates, men who dreamed of finding One Piece—which promises an unlimited amount of riches and fame—and quite possibly the pinnacle of glory and the title of the Pirate King. Enter Monkey D. Luffy, a 17-year-old boy who defies your standard definition of a pirate. Rather than the popular persona of a wicked, hardened, toothless pirate ransacking villages for fun, Luffy's reason for being a pirate is one of pure wonder: the thought of an exciting adventure that leads him to intriguing people and ultimately, the promised treasure. Following in the footsteps of his childhood hero, Luffy and his crew travel across the Grand Line, experiencing crazy adventures, unveiling dark mysteries and battling strong enemies, all in order to reach the most coveted of all fortunes—One Piece.",
                                                                       Image = "https://cdn.europosters.eu/image/1300/posters/one-piece-big-mom-saga-i94377.jpg",
                                                                       Video = "https://www.youtube.com/embed/l_98K4_6UQ0?autoplay=1"
            });
            

        }



    }
}
