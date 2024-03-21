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

## O-pen Closed Principle

Tout code ou classe ne devrait jamais être modifiés pour une évolution (sauf bug), mais devrait être suffisamment ouverte aux évolutions futures. 

## L-iskov Substitution Principle

Toute nouvelle classe dérivée ne doit pas changer le comportement induit par sa classe de base et peut donc se substituer à sa classe de base.

## I-nterface Segregation Principle

Une classe implémentant une interface doit avoir l'utilité de toutes les éléments définis dans cette même interface.

## D-ependency Inversion Principle

Il s'agit d'assurer un couplage faible entre le contrat d'utilisation d'un objet agrégé avec l'implémentation de ce même objet agrégé afin de pouvoir l'injecter. 

# Object Calisthenics

9 règles définissent les Object Calisthenics :
1. Un seul niveau d'indentation par méthode
2. Ne jamais utiliser le mot-clé "else" ou ses dérivés
3. Encapsuler les types primitifs dans des objets
4. First Class Collection
5. Un seul point par ligne (sauf écriture fluide) ou Loi de Demeter
6. Ne pas utiliser d'abrévation
7. Garder les modules ou les entités petites
8. Pas plus de 5 variables d'instances (attributs ou propriétés)
9. Aucun Getter/Setter ou pas de propriété (sauf DTO, VO, Entity) principe de "Tell don't ask"
   
## Un seul niveau d'indentation par méthode

Ce principe améliore la lisibilité et permet d'avoir un code découpé et maintenable.

## Ne jamais utiliser le mot-clé "else" ou ses dérivés

Ce principe permet d'éviter les alternatives compliquées, tout en maintenant la lisibilité avec une code nominal explicite à la fin.
Quelques solutions pour ne plus avoir de "else" :
- Early Exit (cas métier ou respect des préconditions métier)
- Fail fast (exceptionsliés aux prérequis selon respect des préconditions)
- Initialisation en amont

## Encapsuler les types primitifs dans des objets

Il est toujours préférable d'utiliser un type personnalisé plutôt qu'une primitive trop ouverte.

## First Class Collection

Il est préférable d'utiliser une classe hôte pour héberger une collection plutôt que de la mélanger au milieu d'autres considérations métier d'un même objet.

## Un seul point par ligne (sauf écriture fluide) ou Loi de Demeter

Il s'agit ici d'un lien avec la Loi de Demeter consistant à ne pas manipuler le contenu des objets ou désencapsuler depuis l'extérieur.
L'image souvent donné lorsqu'on utilise plusieurs points par ligne : "Imaginons que pour payer le pain, on donne notre veste à la Boulangère en indiquant la marche à suivre pour trouver la monnaie : ouvrir la veste, chercher la poche de droite, récupérer le portefeuille, l'ouvrir et prendre la pièce d'un euro pour payer", au lieu de "Payer la boulangère".

## Ne pas utiliser d'abrévation

## Garder les modules ou les entités petites

Les règles :
- Maximum 10 méthodes par classe
- Maximum 50 lignes par classe
- Maximum 10 classes par namespace

## Pas plus de 5 variables d'instances (attributs ou propriétés)

## Aucun Getter/Setter ou pas de propriété (sauf DTO, VO, Entity) principe de "Tell don't ask"

Lien approche "Tell don't ask"
