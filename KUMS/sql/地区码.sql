select * from area_code  order by area_code;

select * from area_code  t where t.area_code like '%360%' order by area_code;
 360000 江西省
 360700 赣州市
 360731 于都县
 
 
 select * from area_code  t where t.area_code like '%0000' order by area_code;--省
 select * from area_code  t where t.area_code like '%00' order by area_code;--市
 

