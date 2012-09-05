select * from price_index t;
select t.*,t.rowid from price_index t where t.status=0;
select * from finance_order f;


select f.order_no,f.business_time,f.memo,f.rowid from finance_order f 
       where f.memo like '%X%' 
       order by f.memo,f.business_time desc;

select f.order_no,f.business_time,f.memo,f.rowid from finance_order f where f.memo like '%*%';


select f.order_no,f.memo,f.rowid from finance_order f where 1=1
 --and f.memo like '%*%'
 and f.business_time between to_date('2011-10-2 00:00:00','yyyy-mm-dd hh24:mi:ss')
                                  and to_date('2011-10-2 23:59:59','yyyy-mm-dd hh24:mi:ss');
                       
            
 ---translate() 将memo中的*替换为X                                 
update finance_order f
set f.memo=translate(f.memo,'@*','@X')   where f.memo like '%*%'
 and f.business_time between to_date('2011-10-2 00:00:00','yyyy-mm-dd hh24:mi:ss')
                                  and to_date('2011-10-2 23:59:59','yyyy-mm-dd hh24:mi:ss');
                                  
                                   
  
 
