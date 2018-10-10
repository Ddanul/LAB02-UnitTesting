# LAB02-UnitTesting
Code Fellows 401 - Lab 02 ATM machine

# Problem Domain
This console app acts like an Automatic Teller Machine.  The console displays options to either display the balance, withdraw money, deposit money, or exit the application.  There are a few exceptions: You cannot go to a negative balance; and you cannot input anything other than a number.

## Home
<img width="673" alt="lab02home" src="https://user-images.githubusercontent.com/25948479/46761468-63197a00-cc89-11e8-84f4-f2be6a64f0c9.PNG">

## Balance
<img width="675" alt="lab02balance" src="https://user-images.githubusercontent.com/25948479/46761465-63197a00-cc89-11e8-8263-5c744f20a43e.PNG">

## Withdraw
<img width="297" alt="lab02withdraw" src="https://user-images.githubusercontent.com/25948479/46761469-63197a00-cc89-11e8-9e80-7d7d2a7a8d74.PNG">

## Deposit
<img width="277" alt="lab02deposit" src="https://user-images.githubusercontent.com/25948479/46761466-63197a00-cc89-11e8-8e1f-3270c577cd62.PNG">

## Error Handling
<img width="282" alt="lab02error" src="https://user-images.githubusercontent.com/25948479/46761467-63197a00-cc89-11e8-8e01-70767f9d7ab3.PNG">

# Walk Through
1. Open the app
2. The default starting balance is $300.
3. Select an option by entering a number between 1-4.
4. If Withdrawing or Depositing, an amount will be requested.
5. Enter a number, an error will be thrown if not a number.
6. The number must not make the balance go below $0.
7. Continue selecting options until you are content.