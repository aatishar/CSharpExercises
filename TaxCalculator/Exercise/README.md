# Tax Calculator

All incomes are subjected to tax based on specific ranges. However, there's a rebate of **10%** before applying the tax calculation:

For ex.
If a person earns **Rs40000** per month, the tax calculation will be on **90%** of **Rs40000** i.e **Rs36000**.

# Tax Ranges
Tax is calculated based on the below table:

| #    | From (Rs) | To (Rs) | Rate (%) |
| :--- | :---      | :---    | :---     |
| 1    | 0         | 10064   | 0        |
| 2    | 10064     | 27794   | 14       |
| 3    | 27794     | 74517   | 30       |
| 4    | 74517     | 157806  | 41       |
| 5    | 157806    | -       | 45       |

# Exercise 1
As a tax practitioner, I would like to calculate the tax to be paid for **Mary** whose salary is **Rs20000**.

```
Taxable Income = Rs18000 (Rs20000 * 90%)

Range #1 => 0% * 10064 = 0
Range #2 => 14% * (18000 - 10064) = Rs1111.04

Total Tax: Rs1111.04

```
# Exercise 2
As a tax practitioner, I would like to calculate the tax to be paid for **John** whose salary is **Rs31000**.

```
Taxable Income = Rs27900 (Rs31000 * 90%)

Range #1 => 0% * 10064 = 0
Range #2 => 14% * (27794 - 10064) = Rs2482.20
Range #3 => 30% * (27900 - 27794) = Rs31.80

Total Tax: Rs2514.00

```

# Exercise 3
John got an increase of **Rs10000** in his salary. Hence as a tax practitioner, I would like to calculate the tax to be paid for **John** whose salary is now **Rs41000**.

```
Taxable Income = Rs36900 (Rs41000 * 90%)

Range #1 => 0% * 10064 = 0
Range #2 => 14% * (27794 - 10064) = Rs2482.20
Range #3 => 30% * (36900 - 27794) = Rs2731.80

Total Tax: Rs5214.00

```

# Exercise 4
As a tax practitioner, I would like to calculate the tax to be paid for **Gary** whose salary is **Rs90000**.

```
Taxable Income = Rs81000 (Rs90000 * 90%)

Range #1 => 0% * 10064 = 0
Range #2 => 14% * (27794 - 10064) = Rs2482.20
Range #3 => 30% * (74517 - 27794) = Rs14016.90
Range #4 => 41% * (81000 - 74517) = Rs2658.03

Total Tax: Rs19157.13

```

# Exercise 5
As a tax practitioner, I would like to calculate the tax to be paid for **Brian** whose salary is **Rs200000**.

```
Taxable Income = Rs180000 (Rs200000 * 90%)

Range #1 => 0% * 10064 = 0
Range #2 => 14% * (27794 - 10064) = Rs2482.20
Range #3 => 30% * (74517 - 27794) = Rs14016.90
Range #4 => 41% * (157806 - 74517) = Rs34148.49
Range #5 => 45% * (180000 - 157806) = Rs9987.30

Total Tax: Rs60634.89

