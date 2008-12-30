delete from npc_vendor where entry in (select entry from vendors);

REPLACE vendors (entry, item, max_amount, inctime, extended_cost)
SELECT entry, item, maxcount, incrtime, ExtendedCost
FROM npc_vendor;