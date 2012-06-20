 select p.*,p.rowid from Price_Index p where 1=1  
            and  p.snatch_Time  between to_date('2010-01-01 12:00:00','yyyy-mm-dd hh24:mi:ss')
                                  and to_date('2012-01-01 12:00:00','yyyy-mm-dd hh24:mi:ss') 
            and p.status=1  order by p.snatch_time


 select distinct p.snatch_time from Price_Index p where 1=1  
            and  p.snatch_Time  between to_date('2010-01-01 12:00:00','yyyy-mm-dd hh24:mi:ss')
                                  and to_date('2012-01-01 12:00:00','yyyy-mm-dd hh24:mi:ss') order by p.snatch_Time 
                                  
 select * from (
               select distinct to_char(pp.snatch_time,'yyyy-mm-dd') snatch_date from(
                       select p.snatch_time from Price_Index p where 1=1  
                                             and  p.snatch_Time   between to_date('2010-01-01 12:00:00','yyyy-mm-dd hh24:mi:ss')
                                              and to_date('2012-01-01 12:00:00','yyyy-mm-dd hh24:mi:ss') order by p.snatch_time desc 
                                        ) pp
               ) ppp order by ppp.snatch_date;
                                  
select  ppp.snatch_date from ( 
         select distinct to_char(pp.snatch_Time,'yyyy-mm-dd') snatch_date from( 
                select p.snatch_Time from Price_Index p where 1=1 and p.status=1 and p.reference_id in ( 62,44,57,41,55,45,66,61,60,65,63,40,24,25,58,59,21,64,42,20,56 )  
                                     and  p.snatch_Time  between to_date('2011-01-01 00:00:00','yyyy-mm-dd hh24:mi:ss')
                                        and to_date('2012-01-01 23:59:59','yyyy-mm-dd hh24:mi:ss') order by p.snatch_Time desc 
                                 ) pp 
                          ) ppp order by ppp.snatch_date 
                          
                          
                          
                          select t.*, t.rowid from finance_order t where t.tran_type in(1001,1011);

select t.*,t.rowid from price_reference t where t.type=20 order by code;
select t.*, t.rowid from price_index t


select tt.* from price_reference tt where tt.id in( select distinct t.reference_id from price_index t where t.id in(23,24,25));




�۹� ����:18130.55(4.15%)���£�16:00:00ˢ��02328�й�����9.363.65%  00883�к���12.807.74%
  01688����Ͱ�7.2512.93%  01919�й�Զ��3.255.18%  02318�й�ƽ��46.8010.12% 
   04338΢��-T186.000.00%  02628�й�����18.464.29% 
 00001����ʵҵ89.002.95%  00700��Ѷ�ع�160.002.63%  
 
  insert into price_reference(id,code,name,money,type,status)  values(seq_pricereference.nextval,'02328','�й�����','��Ԫ',20,1);
    insert into price_reference(id,code,name,money,type,status)  values(seq_pricereference.nextval,'01688','����Ͱ�','��Ԫ',20,1);
     insert into price_reference(id,code,name,money,type,status)  values(seq_pricereference.nextval,'02318','�й�ƽ��','��Ԫ',20,1);
       insert into price_reference(id,code,name,money,type,status)  values(seq_pricereference.nextval,'00700','��Ѷ�ع�','��Ԫ',20,1);
   

   update price_index p set p.price=(p.max_price+p.min_price)/2
            where 1=1           and p.max_price>0 and p.min_price>0
             
             















