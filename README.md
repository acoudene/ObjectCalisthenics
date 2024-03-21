# ObjectCalisthenics

A repository to expose Object Calisthenics, Law of Demeter (LoW), "Tell don't ask" (TDA) approaches

(in french below...)

# Objectif

L'objectif de ce document est de vous présenter différentes approches pour coder selon des approches industrielles éprouvées. Nous ne parlerons pas ici de Design-Patterns d'architecture mais bien de la pratique concrète du codage.

# Thématiques visées

Nous verrons les thématiques suivantes qui peuvent se recouper :
- Object Calisthenic
- Loi de Demeter
- Approche "Tell don't ask"

# Object Calisthenics

9 règles régissent les Object Calisthenics :
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
