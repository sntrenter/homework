package com.example.autoloancalculatorappsamtrenter;

// Data model for an auto loan
public class AutoLoan {

// Declare constants to store state tax (8%) and interest rate (6%)
    final double STATE_TAX = .08;
    final double INTEREST_RATE = .059;


// Declare private (member) fields for monthly payment, car price, down payment, tax amount,
// total cost, borrowed amount, interest amount, loan term, and loan summary
    private double monthlyPayment;
    private double carPrice;
    private double downPayment;
    private double taxAmount;
    private double totalCost;
    private double borrowedAmount;
    private double interestAmount;
    private String loanTerm;
    private String loanSummary;


// Add an empty constructor method to initialize all field (member variable) values to 0 or “”
    public AutoLoan(){
     monthlyPayment=0;
     carPrice=0;
     downPayment=0;
     taxAmount=0;
     totalCost=0;
     borrowedAmount=0;
     interestAmount=0;
     loanTerm="";
     loanSummary="";
    }


// Add nine getter methods and nine setter methods (one pair for each field)


    public double getMonthlyPayment() {
        return monthlyPayment;
    }

    public double getCarPrice() {
        return carPrice;
    }

    public double getDownPayment() {
        return downPayment;
    }

    public double getTaxAmount() {
        return taxAmount;
    }

    public double getTotalCost() {
        return totalCost;
    }

    public double getBorrowedAmount() {
        return borrowedAmount;
    }

    public double getInterestAmount() {
        return interestAmount;
    }

    public String getLoanTerm() {
        return loanTerm;
    }

    public String getLoanSummary() {
        return loanSummary;
    }

    ////////////////////////////////

    public void setMonthlyPayment() {
        this.monthlyPayment = monthlyPayment;
    }

    public void setCarPrice(double carPrice) {
        this.carPrice = carPrice;
    }

    public void setDownPayment(double downPayment) {
        this.downPayment = downPayment;
    }

    public void setTaxAmount() {
        this.taxAmount = taxAmount;
    }

    public void setTotalCost() {
        this.totalCost = totalCost;
    }

    public void setBorrowedAmount() {
        this.borrowedAmount = borrowedAmount;
    }

    public void setInterestAmount() {
        this.interestAmount = interestAmount;
    }

    public void setLoanTerm(String loanTerm) {
        this.loanTerm = loanTerm;
    }

    public void setLoanSummary() {
        this.loanSummary = loanSummary;
    }
}
