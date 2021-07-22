## String

- CamelCase
```c#
"hello World".CamelCase(); // helloWorld
" hello World".CamelCase(); // helloWorld
" hello World ".CamelCase(); // helloWorld
"  hello  World  ".CamelCase(); // helloWorld
```


- IsGuid
```c#
"8eb06d03-aaf5-491c-9a1f-d16f19a58d61".IsGuid(); // true
"{8eb06d03-aaf5-491c-9a1f-d16f19a58d61}".IsGuid(); // true
"8eb06d03aaf5491c9a1fd16f19a58d61".IsGuid(); // true

string test = null;
test.IsGuid(); // false
"".IsGuid();// false
"Hi, ".IsGuid();// false
"8eb06d03--aaf5--491c--9a1f--d16f19a58d61".IsGuid(); // false
```


- IsNull
```c#
string test = null;
test.IsNull(); // true
"".IsNull(); // false
" ".IsNull(); // False
"Lorem ipsum dolor sit amet".IsNull(); // False
```


- IsNullOrWhiteSpace
```c#
string test = null;
test.IsNullOrWhiteSpace(); // True
"".IsNullOrWhiteSpace(); // True
" ".IsNullOrWhiteSpace(); // True
"Lorem ipsum dolor sit amet".IsNullOrWhiteSpace(); // False
```


- IsNullOrEmpty
```c#
string test = null;
test.IsNullOrEmpty(); // True
"".IsNullOrEmpty(); // True
" ".IsNullOrEmpty(); // False
"Lorem ipsum dolor sit amet".IsNullOrEmpty(); // False
```


- LengthOnly
```c#
"aa AA bb ba".LengthOnly('a'); // 3
"aa aa bb ba".LengthOnly('a'); // 5
"8eb06d03-aaf5-491c-9a1f-d16f19a58d61".LengthOnly('a') // 4
"Lorem ipsum dolor sit amet".LengthOnly('a'); // 1
"Lorem ipsum dolor sit amet".LengthOnly('o'); // 3
```


- LengthMax
```c#
"Lorem ipsum".LengthMax(5); // False
"Lorem ipsum".LengthMax(10); // False
"Lorem ipsum".LengthMax(11); // True
```

- LengthMin
```c#
"Lorem ipsum".LengthMin(15); // False
"Lorem ipsum".LengthMin(3); // True
```


- Random
```c#
random.String(10); // yuhvgnwvfm
random.String(30, true); // hwqddDcMLWluGILRrNQTYbJofNCTXK
random.String(56, true, true, true); // !y&f&ifqGHro83*&uGb%(ZOe^M#UZjPrxvVD8o4D~9nLTR4M%3mkzkyl
```


- Separator
```c#
"1234567890".Separator('-', 2); // 12-34-56-78-90
"ABCDEFGHIJKLMNOP".Separator('-',6); // "ABCDEF-GHIJKL-MNOP
"ABCDE FGHIJK LMNOPQRSTU VWXYZ".Separator('-',5); // ABCDE- FGHI-JK LM-NOPQR-STU V-WXYZ
```



## Numeric
- IsNull
```c#
int? test = null;
test.IsNull(); // true
```

- LengthOnly
- LengthMax
- LengthMin
- Random

## Date
- IsNull
- IsNullOrWhiteSpace
- IsNullOrEmpty
- IsNullOrEmptyOrWhiteSpace
- Random

## Bool
- IsNull
- IsNullOrWhiteSpace
- IsNullOrEmpty
- IsNullOrEmptyOrWhiteSpace
- Random

## GUID
- IsNull


## List
- IsNull