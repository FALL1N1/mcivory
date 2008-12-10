delete from gameobject where id in (select Entry from gameobject_spawns);

REPLACE gameobject_spawns (Entry, map, position_x, position_y, position_z, orientation1)
SELECT id, map, postion_x, position_y, position_z, orientation
FROM gameobject;

UPDATE gameobject_spawns SET scale = '1' WHERE scale = '0';
