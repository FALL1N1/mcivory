insert into creatureloot (entryid, itemid, percentchance, heroicpercentchance, mincount, maxcount) values 
(15975, 44758, 66, 60, 1, 4),(15975, 42253, 26, 22, 1, 3),(15975, 44759, 16, 12, 1, 3),(15975, 33629, 2, 0, 1, 1);
update creature_proto set minlevel=81, maxlevel=81, minhealth=234594, maxhealth=234594 where entry=15975;

insert into creatureloot (entryid, itemid, percentchance, heroicpercentchance, mincount, maxcount) values 
(15981, 33470, 35, 23, 1, 7),(15981, 43852, 17, 12, 1, 1),(15981, 35947, 6, 7, 1, 1),(15981, 33445, 4, 2, 1, 1),(15981, 33447, 2, 0, 1, 1),(15981, 39152, 2, 6, 1, 1);
update creature_proto set minlevel=81, maxlevel=81, minhealth=52130, maxhealth=52130, mana=89790 where entry=15981;
