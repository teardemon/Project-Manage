---ÖÜ±¨
select to_char(next_day(trunc(f.business_time),to_char(date'2012-6-1','Day')),'yyyy-MM-DD') Grp_Date
       ,sum(f.total_amount) Qty
       ,to_char(min(f.business_time),'yyyy-MM-DD HH:mm:ss') min_date
       ,to_char(max(f.business_time),'yyyy-MM-DD HH:mm:ss') max_date
       from finance_order f
       where 1=1
       and f.business_time>=Date'2012-6-1'
       and f.business_time< Date'2012-6-1' +31
       Group by next_day(trunc(f.business_time),to_char(DATE'2012-6-1','Day'))
