# Object Calisthenics

A repository to expose Object Calisthenics, Law of Demeter (LoW), "Tell don't ask" (TDA) approaches

_(in french below...)_

# Objectif

L'objectif de ce document est de vous présenter différentes approches pour coder selon des approches industrielles éprouvées. Nous ne parlerons pas ici de Design-Patterns d'architecture mais bien de la pratique concrète du codage.

# Thématiques visées

Nous verrons les thématiques suivantes qui peuvent se recouper :
- Rappels SOLID
- Object Calisthenics
- Loi de Demeter
- Approche "Tell don't ask"

# Rappels SOLID

Les objectifs des principes SOLID sont de se définir un cadre permettant d'assurer une pérennité, une maintenabilité avec un côté industriel au développement logiciel.

## S-ingle Responsibility Principle

Chaque module, chaque classe ou chaque structure ne doit avoir qu'une seule et unique responsabilité.

Le mal :

```
public class Customer
{
   public string Name { get; set; }

   private readonly int _capital;

   public Customer(int capital)
   {
      _capital = capital ?? throw new ArgumentNullException(nameof(capital));
   }

   public void EarnMoney(uint money) => _capital += money;
   public void SpendMoney(uint money) => _capital -= money;
   public bool CanBuy(int price) => price <= Capital;
        
}
```

Une solution :

```
public class Customer
{
   public string Name { get; set; }

   private readonly FinancialService _financialService;

   public Customer(FinancialService financialService) => _financialService = financialService ?? throw new ArgumentNullException(nameof(financialService));


   public void EarnMoney(uint money) => _financialService.EarnMoney(money);
   public void SpendMoney(uint money) => _financialService.SpendMoney(money);
   public bool CanBuy(int price) => _financialService.CanBuy(money);
}

public class FinancialService
{
   private readonly int _capital;

   public Customer(int capital)
   {
      _capital = capital ?? throw new ArgumentNullException(nameof(capital));
   }

   public void EarnMoney(uint money) => _capital += money;
   public void SpendMoney(uint money) => _capital -= money;
   public bool CanBuy(int price) => price <= Capital;
}
```


## O-pen Closed Principle

## L-iskov Substitution Principle

## I-nterface Segregation Principle

## D-ependency Inversion Principle


# Object Calisthenics

9 règles définissent les Object Calisthenics :
1. Un seul niveau d'indentation par méthode
2. Ne jamais utiliser le mot-clé "else" ou ses dérivés
3. Garder les entités petites
4. Ne pas utiliser d'abrévation
5. Encapsuler les types primitifs dans des objets
6. First Class Collection
7. Un seul point par ligne (sauf écriture fluide)
8. Pas plus de 5 variables d'instances (attributs ou propriétés)
9. Aucun Getter/Setter ou pas de propriété (sauf DTO, VO, Entity)
   
## Un seul niveau d'indentation par méthode

## Ne jamais utiliser le mot-clé "else" ou ses dérivés

Quelques solutions :
- Early Exit
- Fail fast
- Initialisation en amont

## Garder les entités petites

Les règles :
- Maximum 10 méthodes par classe
- Maximum 50 lignes par classe
- Maximum 10 classes par namespace
  
## Ne pas utiliser d'abrévation

## Encapsuler les types primitifs dans des objets

## First Class Collection

## Un seul point par ligne (sauf écriture fluide).

Lien avec la Loi de Demeter ou "Tell don't ask"

## Pas plus de 5 variables d'instances (attributs ou propriétés)

## Aucun Getter/Setter ou pas de propriété (sauf DTO, VO, Entity)

Lien approche "Tell don't ask"
