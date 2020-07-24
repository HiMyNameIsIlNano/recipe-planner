package com.example.demo;

import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.context.SpringBootTest.WebEnvironment;
import org.springframework.boot.web.server.LocalServerPort;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.test.context.ActiveProfiles;

@SpringBootTest(webEnvironment = WebEnvironment.RANDOM_PORT)
@ComponentScan({ "com.example.demo" })
@ActiveProfiles("integration-test")
public abstract class BaseRestIntegrationTest {

    @LocalServerPort private int port;

    public int getPort() {
        return port;
    }
}
