delete from gameobject_template where entry in (select entry from gameobject_names);

REPLACE gameobject_names (entry, Type, DisplayID, Name)
SELECT entry, type, displayid, name
FROM gameobject_template;