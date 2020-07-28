package com.example.demo.grpc.recipe;

import lombok.Getter;
import org.springframework.context.ApplicationEvent;

@Getter
public class InitEvent extends ApplicationEvent {

    enum Reason {
        INIT,
        DELETE_ONE,
        DELETE_ALL;
    }

    private Reason description;

    public InitEvent(Object source) {
        super(source);
        this.description = Reason.INIT;
    }
}
