select * from data_type;
select t.rowid,t.* from assets_item t;

select t.area_code,
(select name from data_type where no= t.item_type)||t.item_type,
       sum(t.item_count) ,
       sum(t.valuation)       
       from assets_item t
       group by t.item_type,t.area_code;
       
       select count(valuation) from assets_item;
       
                                     

--update assets_item t set t.update_time=(select sysdate from dual) where 1=1;
 update assets_item t set t.valuation=0 where 1=1;
  update assets_item t set t.area_code='Öéº£' where 1=1;
  update assets_item t set t.last_deprec_time=t.update_time where 1=1;
  
  
select sysdate from dual;

