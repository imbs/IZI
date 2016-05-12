# IZI
Ancestry International Zoo Institute

Requirements
------------
Requirements are specified in the file *Coding Exercise - Zoo.pdf*

Design Notes
------------
Based on the requirements, the following tables and procedures are required to implement this package.

--- Database Tables ---
- Animals
  * Animal ID
  * Species ID
  * Zoo ID
  * Animal Name
  * Animal type/description
  * Foods [could be multiple]
   * - Food ID
   * - Weight to give
   * - Schedule [could be multiple]
    * -- Frequency: daily, days-of-week, ...
    * -- Time of day

- Foods
  * Food ID
  * Weight on hand
  * Reorder Trigger Weight
  * Weight to reorder
  * Vendor ID (for ordering)

- [optional] Outstanding Orders
  * Vendor ID
  * Zoo ID
  * Food ID
  * Weight ordered
  * Date/time order placed
  * [optional] Expected delivery date

- Species
  * Species ID
  * Species Description

- Vendors
  * Vendor ID
  * Vendor Name
  * Additional Vendor information (address, phone number, terms, ...)

- Workers
  * Worker ID
  * Worker Name
  * [optional] Associated animal ID's
  * [optional] Other worker info (address, payroll ID, ...)

- Waste
  * Food ID
  * Zoo ID
  * Weight wasted
  * Date/time waste recorded

- Zoos
  * Zoo ID
  * Zoo Name
  * Additional Zoo information (address, phone number, ...)

--- Database maintenance ---
- Add/edit/remove Zoo, Animal, Worker, Food, Species, Vendor

--- Procedures ---
- Feed shipment receiving
  * Food ID
  * Zoo ID
  * Weight received
  * Date/time

- Feeding
  * Animal ID
  * Food ID
  * Worker ID
  * Weight given
  * Date/time

- Food Inventory Reconciliation
  * Worker ID
  * Food ID
  * Measured weight on hand

--- Queries/Reporting Procedures ---
- Average food per animal per day
  * [optional] Filtering by Zoo, Species, Worker, ...
  * [optional] Sort orders

- Average number of feedings per animal per day
  * Sort by Species
  * [optional] Filtering by Zoo, Species, Worker, ...
  * [optional] Sort orders

- Amount of food wasted per Zoo
  * [optional] Filtering by Zoo, Species, Worker, ...

- Overfed/Underfed
  * Percentage trigger
  * [optional] Filtering by Zoo, Species, Worker, ...
