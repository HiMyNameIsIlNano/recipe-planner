package com.example.demo.domain.recipe.model;

import com.example.demo.common.definition.StringListType;
import com.example.demo.common.definition.TypedListType;
import com.example.demo.common.model.BaseEntity;
import com.example.demo.domain.recipe.definition.CategoryEnum;
import com.example.demo.domain.recipe.definition.DifficultyEnum;
import com.example.demo.domain.recipe.ingredient.definition.IngredientDefinition;
import com.example.demo.domain.recipe.ingredient.model.Ingredient;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import org.hibernate.annotations.NaturalId;
import org.hibernate.annotations.Parameter;
import org.hibernate.annotations.Type;
import org.hibernate.annotations.TypeDef;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@NoArgsConstructor
@AllArgsConstructor
@Entity
@Getter
@Table(
        uniqueConstraints = @UniqueConstraint(name = "unique_recipe_constraint", columnNames = {"name"})
)
@TypeDef(name = "string-list", typeClass = StringListType.class, defaultForType = String[].class)
@TypeDef(name = "typed-list", typeClass = TypedListType.class, defaultForType = String[].class)
public class Recipe extends BaseEntity {

    @NaturalId
    private String name;

    @Enumerated(value = EnumType.STRING)
    private DifficultyEnum difficulty;

    @Enumerated(value = EnumType.STRING)
    private CategoryEnum category;

    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "recipe_id")
    private List<Ingredient> ingredients;

    @Type(type = "string-list")
    @Column(columnDefinition = "text[]")
    private String[] strings;

    @Type(type = "typed-list", parameters = {
            @Parameter(name = "type", value = "ingredient_definition"),
            @Parameter(name = "definitionClass", value = "com.example.demo.domain.recipe.ingredient.definition.IngredientDefinition")
    })
    @Column(columnDefinition = "ingredient_definition[]")
    private List<IngredientDefinition> ingredientDefinitions = new ArrayList<>();

}
