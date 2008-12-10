delete from creature_template where entry in (select entry from creature_names);

REPLACE creature_names (entry, name, subname, male_displayid, male_displayid2, female_displayid, female_displayid2, Flags1, type, family, rank)
SELECT entry, name, subname, modelid_A, modelid_A2, modelid_H, modelid_H2, type_flags, type, family, rank
FROM creature_template;

REPLACE creature_proto (entry, minlevel, maxlevel, faction, minhealth, maxhealth, mana, scale, npcflags, attacktime, mindamage, maxdamage, rangedattacktime, rangedmindamage, rangedmaxdamage, mountdisplayid, resistance1, resistance2, resistance3, resistance4, resistance5, resistance6, boss, money)
SELECT entry, minlevel, maxlevel, faction_A, minhealth, maxhealth, maxmana, scale, npcflag, baseattacktime, mindmg, maxdmg, rangeattacktime, minrangedmg, maxrangedmg, PetSpellDataid, resistance1, resistance2, resistance3, resistance4, resistance5, resistance6, rank, maxgold
FROM creature_template;