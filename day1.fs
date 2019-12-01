: consumption
    3 / 2 - ;

: full_consumption
    0 swap
    begin
        consumption
        dup rot + swap
        dup
        9 <
    until
    drop
;

: add_fuel
    swap full_consumption + ;

: total
    0
    begin
        add_fuel
        depth 1 <=
    until ;
