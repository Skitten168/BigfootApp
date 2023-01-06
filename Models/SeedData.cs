using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bigfoot.Data;
using System;
using System.Linq;

namespace Bigfoot.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BigfootContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BigfootContext>>()))
            {
                if (context == null || context.Sightings == null)
                {
                    throw new ArgumentNullException("Null BigfootContext");
                }
                // Look for any cryptids.
                if (context.Sightings.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sightings.AddRange(
                    new Sightings
                    {
                        State = "Ohio",
                        Month = "May",
                        Year = "1988",
                        Class = "B",
                        Occurence = "Campers had small stones thrown at their tent. Also heard grunting noises similiar to an ape.",
                        Location = "Southeast Fairbanks Borough",
                        Description = "Campers were accosted by BigFoot and heard it making noises, no physical sighting or contact.",
                        /*PhotoPath = "bigfoot.jpg"*/
                    },
                    new Sightings
                    {
                        State = "Florida",
                        Month = "January",
                        Year = "2005",
                        Class = "A",
                        Occurence = "While fishing a man saw what could only be BigFoot.",
                        Location = "Miami",
                        Description = "Fisherman saw a large orangutan like creature walking in the shallows amoung some cattails.",
                    },

                    new Sightings
                    {
                        State = "Washington",
                        Month = "July",
                        Year = "2015",
                        Class = "B",
                        Occurence = "Hikers frightened by BigFoot crossing a path in front of them.",
                        Location = "Pacific County",
                        Description = "While walking a couple of hikers were spooked by a BigFoot who was ambling across the path in front of them, he was large and covered in fur, thankfully not aggressive.",
                        
                    },

                    new Sightings
                    {
                        State = "Illinois",
                        Month = "August",
                        Year = "2003",
                        Class = "A",
                        Occurence = "A man witnessed BigFoot swimming in a lake.",
                        Location = "Lake County",
                        Description = "While fishing a man noticed a large creatures head swimming accross a lake, he was surprised when it got out a few hundred feet from him and was a BigFoot who disappeared quickly into the woods when observed.",
                        
                    },

                    new Sightings
                    {
                        State = "Michigan",
                        Month = "March",
                        Year = "2007",
                        Class = "B",
                        Occurence = "A woman witnessed BigFoot from her kitchen window.",
                        Location = "Grand Traverse County",
                        Description = "A woman washing dishes witnessed a shadowy figure covered in fur in the woods behind her house.",
                    },

                    new Sightings
                    {
                        State = "Texas",
                        Month = "September",
                        Year = "2017",
                        Class = "A",
                        Occurence = "A Cowboy watching his flock witnessed a BigFoot carrying a sheep off.",
                        Location = "Denton",
                        Description = "A Cowboy tending to his sheep witnessed a BigFoot carry a sheep off in the dusk, when it would be able to escape into darkness and not be found."
                    },

                    new Sightings
                    {
                        State = "California",
                        Month = "May",
                        Year = "1979",
                        Class = "A",
                        Occurence = "Sighting off Indian Road behind isolated (at the time) Desert Hot Springs Condo complex",
                        Location = "Riverside County",
                        Description = "Was going back to close shop at approx. 10PM in the northern desert above Palm Springs, CA., and saw a huge light tan colored biped with soft blowing hair .Because I was in a small VW bug with the light pointing down into the street upon leaving the driveway facing out into the desert.\r\n\r\nI froze there with my dim headlight on it and it too froze there completely still,. I flashed my worthless high beams at it and it took 2 giant steps backwards and then one to my left, it's right and was gone into the dark. I was overcome with severe fear, panic and anxiety, and had to return home again.",
                    },

                    new Sightings
                    {
                        State = "Washington",
                        Month = "April",
                        Year = "2003",
                        Class = "A",
                        Occurence = "Nighttime sighting by motorist on KM Hill near Skamokawa",
                        Location = "Wahkiakum County",
                        Description = "On 4-24-03, my friend was driving home from work from Naselle, WA to Puget Island, WA around 12:30 a.m. on Highway 4 (Wahkiakum County, WA). He observed a large bipedal animal (approx. 6 to 8 feet tall) broad shouldered with dark bluish/grey hair walking down a steep slope on the other side of the guardrail at the top of KM Hill.",                      
                    },

                    new Sightings
                    {
                        State = "Oregon",
                        Month = "March",
                        Year = "1985",
                        Class = "B",
                        Occurence = "Possible Injured Juvenile on I-84 near Boardman",
                        Location = "Morrow",
                        Description = "While driving the road started to bend south a bit and we came to the first incline and in the headlights of my truck appeared this figure, at first I thought it was some animal that was crossing the road but as we got closer and the lights of the truck became more focused on it, we realized that it was not a common anima!\r\n\r\nIt looked to be about three to four feet tall with the strangest red colored hair covering it's body. But the thing is, it was sitting in the road facing us with one leg straight out and the other leg out to it's right side, and it was trying to push itself up (as if it had been hit by a car).",                      
                    },
                    new Sightings
                    {
                        State = "Nebraska",
                        Month = "May",
                        Year = "2018",
                        Class = "B",
                        Occurence = "Possible daylight sighting of a Sasquatch on the Omaha Indian Reservation.",
                        Location = "Thurston County",
                        Description = "Hikers in the morning witnessed a BigFoot sighting.",
                        
                    },
                    new Sightings
                    {
                        State = "Nebraska",
                        Month = "December",
                        Year = "1979",
                        Class = "A",
                        Occurence = "Creature seen walking across pasture in daylight north of Grand Island.",
                        Location = "Howard County",
                        Description = "Farmer checking on livestock witnessed a Bigfoot.",
                    },
                    new Sightings
                    {
                        State = "North Dakota",
                        Month = "September",
                        Year = "2005",
                        Class = "A",
                        Occurence = "Multiple witness sighting near White Shield",
                        Location = "McLean County",
                        Description = "On Aug 26 around 2:20-2:30am my two cousins were driving back from Minot, they took the back roads to get home faster. They were about 2-3 miles from home on Counrty Road 7 when they said that they were just talking and notice on the left side in the North bound lane a large brown hairy 7-8ft tall thing was standing there, they said they were going about 50-55mph and slowed down a bit, as they passed by it they taped on the brake and in the brake lights they saw it and punched it back home, they said they were so scared that they were going aleast 90mph to get back.",
                    },
                    new Sightings
                    {
                        State = "Nevada",
                        Month = "February",
                        Year = "2005",
                        Class = "B",
                        Occurence = "Hikers spot a dark figure walking on a snowy mountainside near Winnemucca",
                        Location = "Humboldt",
                        Description = "Two hikers observed a BigFoot like creature while hiking up a snowy Mountainside near Winnemucca, the hikers are assured they were the only humans out there that day.",
                    },
                    new Sightings
                    {
                        State = "New Mexico",
                        Month = "July",
                        Year = "2020",
                        Class = "B",
                        Occurence = "Possible Sasquatch wood knocks in forested riverbed beside Chama during lockdown",
                        Location = "Rio Arriba County",
                        Description = "A couple of elderly hikers walking their dogs during lockdown observed loud knocking noises that resonated throughout the forest. Heard but not observed.",
                    },
                    new Sightings
                    {
                        State = "South Dakota",
                        Month = "June",
                        Year = "2019",
                        Class = "B",
                        Occurence = "Possible howls heard 4 miles north of Rochford in middle of Black Hills",
                        Location = "Pennington County",
                        Description = "A visitor at a family farm heard howling and screaming that went on for many minutes. The howling was enough to scare all animals and humans into silence.",
                    },
                    new Sightings
                    {
                        State = "Montana",
                        Month = "April",
                        Year = "2020",
                        Class = "A",
                        Occurence = "Sighting by trucker on Hwy 90 at Lookout Pass outside Tammany",
                        Location = "Mineral County",
                        Description = "Trucker had a very good look at a long reddish haired bigfoot standing up right on the back side of concrete barrier, long reddish brown hair. Couldn’t get a height since it was on other side of barrier.",
                    },
                    new Sightings
                    {
                        State = "Utah",
                        Month = "September",
                        Year = "2022",
                        Class = "A",
                        Occurence = "Late night sighting 15 miles SE of Heber City near Hwy 40",
                        Location = "HWY 40",
                        Description = "Brief sighting of it walking downhill through the trees on edge of Daniel's summit lodge property. Approximately 100 yards away from the cabin we were staying in. Awoke from our 2 dogs being agitated by the cabins open window. Wife walked to the window and observed large figure walking through the trees for a brief time before disappearing behind a structure.",
                    },
                    new Sightings
                    {
                        State = "Arizona",
                        Month = "August",
                        Year = "2021",
                        Class = "A",
                        Occurence = "20 miles east of Petrified Forest National Park -- motorhome driver and wife report daylight sighting from Interstate 40",
                        Location = "HWY 40",
                        Description = "Heading west on I-40 today at 0930 my wife and I saw a Bigfoot 100-150 yards from the hwy heading north. It was not running, but walking. It never looked at the hwy. It must have been 7-8 ft tall. It was thick, as in well built!",
                    },
                    new Sightings
                    {
                        State = "Oklahoma",
                        Month = "August",
                        Year = "2022",
                        Class = "B",
                        Occurence = "Big howls heard by property owner, stones throw from OK/AR border near Mena AR",
                        Location = "La Flore County",
                        Description = "I have lived in the area east of hwy 259 and hwy 63 also known as Big Cedar for 36 years. I was outside my home and I heard 7-10 howlings to the north. It was a sound I've never heard in the area before. I've spent considerable time in these woods. Hunting fishing as a teen I would camp alone with my squirrel dog. The only time I've heard anything like it was on TV during the big foot shows.",
                    },
                    new Sightings
                    {
                        State = "Colorado",
                        Month = "May",
                        Year = "2020",
                        Class = "B",
                        Occurence = "Hikers find large footprint and unidentified droppings",
                        Location = "Chaffee County",
                        Description = "I noticed animal droppings that appeared large human shaped under the uphill undergrowth, spaced every 10-20ft. I commented on the size and shape of the droppings with my wife and agreed they couldn’t be human as there were too many and under the branches of the uphill side We discussed how they appeared to be marking a territory. The droppings continued for maybe 150ft. We continue down/East on the trail. At about the 1/2 mile marrk a deer startled us running from the uphill side across the trail and down the other side. My wife was spooked and we turned around to go back. As we neared the spot where the droppings were I spotted a single foot print on the uphill side partly hidden by branches.",
                    },

                    new Sightings
                    {
                        State = "Wisconsin",
                        Month = "october",
                        Year = "2021",
                        Class = "B",
                        Occurence = "Sighting, photos and video (distant) of a probable Sasquatch near Lac Du Flambeau Indian Rez",
                        Location = "Vilas County",
                        Description = "Wanted to pass this by you as I was out duck hunting today (10/17/21) in north central Wisconsin… Powell Marsh area to be exact.\r\n\r\nThis is a very remote marsh area surrounded by hundreds of thousands of acres of state and National forests. You can access this marsh zone via paths the DNR has to maintain Water levels and people do watch migratory birds from a couple observation areas along road.\r\n\r\nI was more on a walk with the potential to jump shoot some puddle ducks as you can see not a cloud around. Nor were there ducks.\r\n\r\nNot even sure it is a sighting but seemed rather strange. Something told me to look behind me as I was going the opposite direction as the figure. After watching this object for a couple hundred yards I decided to grab my cell phone.\r\n\r\nIt is a long way away but appears black, large, and fast. We have bear, very few moose, wolves, and occasional Elk around. Feel free to say it is a guy on a bike-riding in the peat moss, or a guy on a 4 wheeler in a prohibited motorized vehicle area.\r\n\r\nIt appears to be bipedal and walking deeper into the swamp in the muck. It is hunting season and I wouldn’t expect a person to be dressed in all black in a public hunting area. I tried walking in it and turned back after about 5 feet.\r\n\r\nWith naked eye I could see much better. The figure seemed to float as it moved across the swamp. Again a guy on a bike?\r\n\r\nAfter my hunt, I returned to the only 2 access areas to see if there were vehicles with bike racks or people out for a peat bog run. There was nobody around.\r\n\r\nI have been to the Marsh countless times and have never seen something like this. Although the distance a bit far for video. Figure seems quite large.\r\n\r\nClearly appears to be in muck. I have photos and video but iPhone is a long way away and i am not an editing expert. I am sure video can be manipulated and enhanced.",
                        
                    },

                     new Sightings
                     {
                         State = "Wisconsin",
                         Month = "July",
                         Year = "2021",
                         Class = "A",
                         Occurence = "Motorist sighting of a sasquatch LAST NIGHT 25 miles northwest of Milwaukee",
                         Location = "Washington County",
                         Description = "My son reported seeing a two legged large figure covered in fur at approximately 8:30pm on July 18 2021 while driving eastbound on Pleasant Hill road roughly 1.5 miles west of Hwy 164 in Richfield WI.\r\n\r\nThis figure was standing right next to a tree on the south side of the road close to the shoulder. The road is curvy in this area. He said he also caught eye shine and the eyes were large. We said he probably saw this for about 3 seconds while driving. His headlights caught this and he is 100% positive he saw something. He said his heart dropped and he immediately called me while still driving. I knew something unique happened based on his demeanor and tone.\r\n\r\nAbout 45 minutes after he called me I met him at home and went back to the site with him. We brought our dog. Every time we stopped or approached this area where the sighting was he started to whimper and would not get any closer.",
                         
                     },

                    new Sightings
                    {
                        State = "Wisconsin",
                        Month = "March",
                        Year = "2019",
                        Class = "A",
                        Occurence = "Sasquatch sighting by motorists along South Turcott Road six miles north of Tripoli",
                        Location = "Oneida County",
                        Description = "On Sunday, July 07, 2019, my brother, sister and I took an excursion through Northern Wisconsin. We were traveling north on South Turcott Road, approximately 6.5 miles north of Tripoli, WI. Turcott is a rough, gravel road and we were traveling approximately 10-15 mph in a Chevy Suburban. My brother was driving, I was in the front passenger seat, and our sister was in the right rear passenger seat.\r\n\r\nThe day was clear and cool. Our windows were rolled up because the deer flies were very thick. As we drove through the forest, we came to a clearing to our right, on the east side of the road. The clearing had a lot of brush and fallen logs as it had been logged off. Across the clearing to our east, approximately 100-150 yards away, the forest began again.\r\n\r\nI was looking out across the clearing when I saw a large, reddish-brown, upright figure running along the edge of the trees in the distance. It seemed to be hunched over as it ran. It was too large to be a deer, and did not have a proper height, or gait, for a bear. I only saw it for a moment before my view was obstructed by brush. I wasn’t sure what I saw so I turned to my brother and said, “I think I just saw…” At that moment, he abruptly stopped the vehicle and pointed out my window and yelled, “THERE!!!” My sister and I both looked, but it was gone.\r\n\r\nI asked my brother what he saw and he said it was a big, hairy, reddish-brown figure with no neck, nor muzzle - thick, and too tall to be a deer. He said it was standing upright on the edge of the woods. He estimated it to be about six feet in height and he said he saw it look over its shoulder before it ran into the woods. He also said the smaller trees moved aside like it was pushing its way into the woods.\r\n\r\nAfter he told me what he saw, I told him that what I saw was exactly the same color and I’d have described it exactly the same way: Big, hairy, reddish-brown, and hunched over.\r\n\r\nALSO NOTICED: There was a heavy insect population (mosquitoes,deer flies, horse flies) but at the time of the sighting, there seemed to be be no insects present. We also noted that we had not seen any animal tracks prior to the incident. After the incident, we began seeing insects again and discovered tracks from both bear and wolf some distance north of the sighting.",
                    },

                    new Sightings
                    {
                        State = "New York",
                        Month = "October",
                        Year = "2022",
                        Class = "B",
                        Occurence = "Possible daylight sighting in Adirondacks 15 miles NW of Lake Placid",
                        Location = "Franklin County",
                        Description = "On our way back to Paul Smith's College from our dendrology lab I noticed a large figure out the window by the powerlines. At first I thought it was a large man in a fur coat because I could see its arms, legs, head, and torso; but this creature was much too big to be a man and the fur seemed to be covering its entire body. It was about 1/3 the size of the telephone poles (about 30ft poles) that made up the powerlines and was walking enough to them for me to have a good comparison. That would make this thing about 8-10ft tall roughly. It had it's back to me and seemed to be casually \"strolling\" North along the path the powerlines went. It was moving slow and didn't seem spooked by any of the traffic on the road. But it was a good 100-125 yards down the powerlines so maybe that's why it wasn't spooked.",
                    },
                    new Sightings
                    {
                        State = "New York",
                        Month = "May",
                        Year = "2022",
                        Class = "A",
                        Occurence = " Reliable motorist sighting of a sasquatch 2.5 miles SW of Keeseville (Adirondacks - Ausable River)",
                        Location = "Southeast Fairbanks Borough",
                        Description = "This witness cannot precisely pinpoint the spot along the road where the figure was standing, but it is close to this spot, give or take 100 feet: 44.485509, -73.525189\r\n\r\nNEAREST TOWN: Keeseville NY\r\n\r\nNEAREST ROAD: Augar Lake Rd\r\n\r\nOBSERVED: 3:20 in afternoon this date, driving east on Dugway road in Chesterfield NY Essex County. Sunny weather, road is shady in spots. Observed a tall & black sasquatch standing on left side of road next to a large white pine tree, possibly 300' ahead of my car.\r\n\r\nSaid to myself \"what the hell\" it was gone down the hill. I stopped, got out & searched for prints or maybe catch a smell, found nothing, smelled nothing.\r\n\r\nClocked milage to next road intersection with the Augar Lake Rd to be 1+ mi, went back & scoured around a little more but did not find anything I can report.",
                    },

                    new Sightings
                    {
                        State = "New York",
                        Month = "May",
                        Year = "2022",
                        Class = "A",
                        Occurence = "Turkey hunter observes a sasquatch in daylight 2 miles SW of Erwin",
                        Location = "Steuben County",
                        Description = "Town of Erwin New York State when I was hunting spring turkeys.\r\nI was sitting at the base of a tree location at the top of a ridge line that connected to another ridge. I was calling gobbler turkeys that were on their roost trees, when at which time the gobblers flew down off the ridge from their roost.\r\n\r\nI was still sitting at the base of the tree having not moved location for a half hour when I noticed something walking on two legs approximately 75 yards away. The thing was about 7 feet tall.\r\n\r\nI first thought maybe another human was there hunting, but then it was apparent to me it was dark reddish brown from head to feet. This thing was in my view of sight for about 4 to 5 seconds and then went behind a tree and that was the last I seen it. Then about 15 minutes later (I have not moved from the base of the tree sitting on the ground same spot) to my left approximately 30 yards an object hit a tree about 25 feet up in the tree. Then the object that hit the tree hit the ground sounded like a rock. I continued through the area for the rest of the morning with no further incident. I have hunted in New York for 42 years and never witnessed something like this before.",
                    },

                    new Sightings
                    {
                        State = "Ohio",
                        Month = "July",
                        Year = "2021",
                        Class = "B",
                        Occurence = "Missing chickens lead to discovery of large footprints by chicken coop near Bloomingdale",
                        Location = "Jefferson County",
                        Description = "On July 9th at approximately 10:00 A.M. I noticed my five chickens were missing. The chicken coop was full of feathers but no bodies or blood. I did a perimeter check and came across an extremely large footprint. I went back to the house and brought down a tape measure to the footprint and measured it and took pictures with the tape measure beside it. The foot print measured Length: 18\" Width: 9\"-10\".\r\n\r\nOn the 23rd of July, Jim Thompson BFRO Investigator of Ohio had contacted me and came out to investigate. During Jim's first visit he found four more footprints near the original footprint. Jim stated that the other footprints were about four feet spread apart from each other.\r\n\r\nOn July 24th at approximately 12:38 A.M. I heard a sort of yelping noise coming from one end of my property and heard a quick response (same type of noise) come from the other end of my property. At night time every now and then on my property I get an eerie feeling that something is watching me.",
                    },
                    new Sightings
                    {
                        State = "Ohio",
                        Month = "July",
                        Year = "2021",
                        Class = "B",
                        Occurence = "Campers had small stones thrown at their tent.  Also heard grunting noises similiar to an ape.",
                        Location = "Mahoning County",
                        Description = "Through the years I have had several sightings and interactions with what appears to be a bigfoot and family. We own the better part of mystic woods in Columbiana OH. When the gas and oil companies started installing pipelines years back we started having encounters.\r\nI’m an engineer by trade and my wife is a banker.\r\n\r\nTonight yet another sighting by our pond. My wife and I were at dinner and as we arrived home about 8:30 PM a very large fast gray/ silver lite brown (covered in fur/hair) bigfoot darted from bushes in our front into the cat tails in our pond on all fours. We both looked at each other and said did you just see that?!! The subject was down low and bent in the middle as it moved. Unlike a dog, it’s undulating movement was not as fluid as a dog. It was not a bear. It appeared to be from 4-5 feet at the back and torso built like a barrel. When it went into the cattails we were no longer able to see it.",
                    },

                    new Sightings
                    {
                        State = "Ohio",
                        Month = "October",
                        Year = "1979",
                        Class = "B",
                        Occurence = "Two men find unusual brush structure while deer hunting 10 miles east of Cambridge",
                        Location = "Guernsey County",
                        Description = "What myself and brother in law found was a structure built of mainly blackberry vines. We were scouting for deer on an abandoned farm in an area that had been stripped for coal 35yrs prior. Deer were plentiful, but not as much as present day. When came across it when we both were following a path that materialized and split in two directions around a spoil bank. My brother in law went one way I the other, both paths lead to the top of the spoil were we came on the structure. We were in total amazement noting it was kind of an igloo shape with an opening to enter. The briars where woven together to form the walls and the inside had been cleared like it had been mowed.\r\n\r\nWe stood amazed at what could have made it. We had never heard much about a Bigfoot at that time. Nobody in they’re right mind would have been in the area fighting thorny vegetation and biting insects to create such a thing. Than about a month later the same brother in law and his cousin were walking out of a hollow near dark when they heard the strangest animal they had ever heard. When they would try to tell the family about it they got laughed at. Neither ever forgot it or entered the property in the dark. It wasn’t until maybe 20 years later when I happened on a Bigfoot program showing such a structure that a bell went off as to what we’d saw.\r\nAlso around the time other people had reported seeing things peeking in windows around the county",
                    }



                );
                context.SaveChanges();
            }
        }
    }
}
