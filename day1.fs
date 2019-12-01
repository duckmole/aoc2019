: consumption
    3 / 2 - ;

: add_fuel
    swap consumption + ;

: total
    100 0 ?DO add_fuel LOOP ;

0 total