select * from data_type;

select t.rowid,t.* from assets_item t;

---统计
select t.area_code,
(select name from data_type where no= t.item_type)||t.item_type,
       sum(t.item_count) ,
       sum(t.valuation)       
       from assets_item t
       group by t.item_type,t.area_code;
       
       select count(valuation) from assets_item;
       
       
 ---查询可列入记入资产的订单明细
 select f.id,f.order_no,f.memo,f.total_amount,f.tran_type,f.create_time from finance_order f
        where 1=1
        and f.tran_type in(120121,120131,120135)
       and f.id not in(select t.finance_order_id from assets_item t)
        --and f.id not in(181646089)
        and f.total_amount>10
        order by f.tran_type;
        
        select f.id,f.memo,f.total_amount from finance_order f where f.id  in(181646112);
                                     

--update assets_item t set t.update_time=(select sysdate from dual) where 1=1;
 update assets_item t set t.valuation=0 where 1=1;
  update assets_item t set t.area_code='珠海' where 1=1;
  update assets_item t set t.last_deprec_time=t.update_time where 1=1;
  
  update assets_item t set t.finance_order_id=1 where 1=1 and t.finance_order_id<10;
  
  select * from assets_item where finance_order_id=null
  
  
  select * from data_type;
  
select sysdate from dual;

