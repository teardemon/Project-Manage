create or replace procedure convert_finance_index(sessionId in String) is

begin
  insert into price_index
    (
      id,
      reference_id,
      price,
      snatch_time,
      entry_operator,
      max_price,
      min_price,
      range,
     gather_Company,
      status
    )
   select
     Seq_Priceindex.Nextval,
     1,
     a.total_amount,
     a.business_time,
     a.entry_operator,
     0,
     0,
     0,
     a.cussent_company_id,
     0
     from finance_order a
     where 1=1 and a.status not in(88)
   and a.business_time between to_date('2012-08-23 12:00:00','yyyy-mm-dd hh24:mi:ss')
                                  and to_date('2012-08-24 12:00:00','yyyy-mm-dd hh24:mi:ss');
     commit;

end convert_finance_index;
/
